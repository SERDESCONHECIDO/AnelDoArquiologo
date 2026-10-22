using System;
using System.Linq;
using HarmonyLib;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.GameData.Objects;

namespace AnelDoArqueologo
{
    public class ModEntry : Mod
    {
        private const string RingName = "AnelDoArqueologo_Item";
        private const string RingQualifiedId = "(O)" + RingName;
        internal static bool IsProcessing = false; // Trava anti-crash

        public override void Entry(IModHelper helper)
        {
            helper.Events.Content.AssetRequested += OnAssetRequested;
            helper.Events.GameLoop.SaveLoaded += OnSaveLoaded;

            var harmony = new Harmony(this.ModManifest.UniqueID);
            harmony.PatchAll();
        }

        private void OnAssetRequested(object sender, AssetRequestedEventArgs e)
        {
            if (e.NameWithoutLocale.IsEquivalentTo("Data/Objects"))
            {
                e.Edit(asset =>
                {
                    var data = asset.AsDictionary<string, ObjectData>().Data;
                    data[RingName] = new ObjectData
                    {
                        Name = RingName,
                        DisplayName = "Anel do Arqueologo",
                        Description = "Aumenta drasticamente a quantidade de itens obtidos ao cavar com a pa.",
                        Type = "Ring",
                        Category = -96, 
                        Price = 2500,
                        Texture = "Maps/springobjects",
                        SpriteIndex = 526, // Textura do Anel do Ladrão
                        CanBeGivenAsGift = true,
                        CanBeTrashed = true
                    };
                });
            }
        }

        private void OnSaveLoaded(object sender, SaveLoadedEventArgs e)
        {
            if (!Game1.player.Items.Any(i => i?.QualifiedItemId == RingQualifiedId))
            {
                var ring = new StardewValley.Objects.Ring(RingName);
                Game1.player.addItemToInventory(ring);
                this.Monitor.Log("Anel do Arqueologo adicionado ao inventario.", LogLevel.Info);
            }
        }

        internal static bool HasRingEquipped()
        {
            if (Game1.player == null) return false;
            return Game1.player.leftRing.Value?.QualifiedItemId == RingQualifiedId || 
                   Game1.player.rightRing.Value?.QualifiedItemId == RingQualifiedId;
        }
    }

    // --- PATCH: Multiplica os itens dropados ao usar a Pá ---
    [HarmonyPatch(typeof(Game1), nameof(Game1.createObjectDebris))]
    public static class DigDropPatch
    {
        // Usa a assinatura mais comum da 1.6 para criação de itens
        [HarmonyPatch(new Type[] { typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(GameLocation) })]
        public static class StringIdPatch
        {
            static bool Prefix(string id, int xTile, int yTile, int groundLevel, int itemQuality, float velocityMultiplyer, GameLocation location)
            {
                // Se já estamos multiplicando, ou o jogador não está com o anel, ou não é uma pá, segue o fluxo normal
                if (ModEntry.IsProcessing || !ModEntry.HasRingEquipped()) return true;
                if (!(Game1.player.CurrentTool is StardewValley.Tools.Hoe)) return true;

                ModEntry.IsProcessing = true;
                try
                {
                    // O jogo ia dropar 1 item. Nós dropamos o original + 3 extras (total 4)
                    for (int i = 0; i < 3; i++)
                    {
                        Game1.createObjectDebris(id, xTile + Game1.random.Next(-16, 17), yTile + Game1.random.Next(-16, 17), groundLevel, itemQuality, velocityMultiplyer, location);
                    }
                }
                finally
                {
                    ModEntry.IsProcessing = false;
                }
                return true; // Deixa o jogo criar o item original também
            }
        }

        // A 1.6 também possui uma versão que recebe ID numérico (int)
        [HarmonyPatch(new Type[] { typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(float), typeof(GameLocation) })]
        public static class IntIdPatch
        {
            static bool Prefix(int id, int xTile, int yTile, int groundLevel, int itemQuality, float velocityMultiplyer, GameLocation location)
            {
                if (ModEntry.IsProcessing || !ModEntry.HasRingEquipped()) return true;
                if (!(Game1.player.CurrentTool is StardewValley.Tools.Hoe)) return true;

                ModEntry.IsProcessing = true;
                try
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Game1.createObjectDebris(id, xTile + Game1.random.Next(-16, 17), yTile + Game1.random.Next(-16, 17), groundLevel, itemQuality, velocityMultiplyer, location);
                    }
                }
                finally
                {
                    ModEntry.IsProcessing = false;
                }
                return true; 
            }
        }
    }
}
