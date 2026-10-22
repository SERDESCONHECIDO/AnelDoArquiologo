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

    // --- PATCH ÚNICO: Multiplica itens dropados (Apenas ID String, como exige a 1.6) ---
    [HarmonyPatch]
    public static class DigDropStringPatch
    {
        static System.Reflection.MethodBase TargetMethod()
        {
            return AccessTools.GetDeclaredMethods(typeof(Game1))
                .FirstOrDefault(m => m.Name == "createObjectDebris" && m.GetParameters().Length == 7 && m.GetParameters()[0].ParameterType == typeof(string));
        }

        static bool Prefix(string id, int xTile, int yTile, int groundLevel, int itemQuality, float velocityMultiplyer, GameLocation location)
        {
            // Se já estamos multiplicando, ou o jogador não está com o anel, ou não é uma pá, segue o fluxo normal
            if (ModEntry.IsProcessing || !ModEntry.HasRingEquipped()) return true;
            if (Game1.player.CurrentTool is not StardewValley.Tools.Hoe) return true;

            ModEntry.IsProcessing = true;
            try
            {
                // Dropa 3 itens extras (Total 4, considerando o original do jogo)
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
