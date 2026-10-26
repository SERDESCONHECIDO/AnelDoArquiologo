2026-10-26T16:41:20.3375104Z Versão atual do executor: '2.338.0'
2026-10-26T16:41:20.3406239Z ##[group]Provisionador de Imagem do Runner
2026-10-26T16:41:20.3407276Z Agente de Computação Hospedado
2026-10-26T16:41:20.3408222Z Versão: 20261021.618
2026-10-26T16:41:20.3409115Z Commit: 21505ad2541d5be6135ed84fc33697146cf75b8e
2026-10-26T16:41:20.3410045Z Data de compilação: 2026-10-21T00:45:21Z
2026-10-26T16:41:20.3410967Z ID do trabalhador: {51b390c2-0638-4219-8e9e-9ca550a56c1b}
2026-10-26T16:41:20.3411927Z Região: leste
2026-10-26T16:41:20.3412650Z Nuvem: Azure
2026-10-26T16:41:20.3413436Z ##[endgroup]
2026-10-26T16:41:20.3415120Z ##[grupo]Sistema Operacional
2026-10-26T16:41:20.3416010Z Ubuntu
2026-10-26T16:41:20.3416645Z 26.04.1
2026-10-26T16:41:20.3417323Z LTS
2026-10-26T16:41:20.3418143Z ##[endgroup]
2026-10-26T16:41:20.3418913Z ##[group]Imagem do Corredor
2026-10-26T16:41:20.3419684Z Imagem: ubuntu-26.04
2026-10-26T16:41:20.3420767Z Versão: 20261012.163.1
2026-10-26T16:41:20.3422411Z Software incluído: https://github.com/actions/runner-images/blob/ubuntu26/20261012.163/images/ubuntu/Ubuntu2604-Readme.md
26/10/2026 16:41:20.3424550Z Lançamento da imagem: https://github.com/actions/runner-images/releases/tag/ubuntu26%2F20261012.163
2026-10-26T16:41:20.3425851Z ##[endgroup]
2026-10-26T16:41:20.3427440Z ##[group]GITHUB_TOKEN Permissões
2026-10-26T16:41:20.3430157Z Conteúdo: ler
2026-10-26T16:41:20.3430939Z Metadados: lidos
2026-10-26T16:41:20.3431671Z Pacotes: ler
2026-10-26T16:41:20.3432330Z ##[grupo final]
2026-10-26T16:41:20.3434764Z Fonte secreta: Ações
2026-10-26T16:41:20.3435905Z Modo de cache: escrita
2026-10-26T16:41:20.3437058Z Preparar diretório de fluxo de trabalho
2026-10-26T16:41:20.3822055Z Prepare todas as ações necessárias
2026-10-26T16:41:20.3877948Z Obtendo informações de download da ação
2026-10-26T16:41:20.5654501Z Baixar repositório de ações 'actions/checkout@v4' (SHA:11d5960a326750d5838078e36cf38b85af677262)
2026-10-26T16:41:20.7408059Z Baixar repositório de ações 'actions/setup-dotnet@v4' (SHA:67a3573c9a986a3f9c594539f4ab511d57bb3ce9)
2026-10-26T16:41:20.9137889Z Baixar repositório de ações 'actions/upload-artifact@v4' (SHA:ea165f8d65b6e75b540449e92b4886f43607fa02)
2026-10-26T16:41:21.1356411Z Nome completo da tarefa: build
2026-10-26T16:41:21.2096813Z ##[group]Executar ações/checkout@v4
2026-10-26T16:41:21.2097482Z com:
2026-10-26T16:41:21.2098019Z repositório: SERDESCONHECIDO/AnelDoArquiologo
2026-10-26T16:41:21.2101360Z token: ***
2026-10-26T16:41:21.2101702Z ssh-strict: true
2026-10-26T16:41:21.2102056Z ssh-user: git
2026-10-26T16:41:21.2102405Z persist-credentials: true
2026-10-26T16:41:21.2102788Z limpo: verdadeiro
2026-10-26T16:41:21.2103144Z sparse-checkout-cone-mode: true
2026-10-26T16:41:21.2103549Z profundidade de busca: 1
2026-10-26T16:41:21.2103883Z fetch-tags: false
2026-10-26T16:41:21.2104228Z mostrar-progresso: verdadeiro
2026-10-26T16:41:21.2104579Z lfs: falso
2026-10-26T16:41:21.2104904Z submódulos: falso
2026-10-26T16:41:21.2105255Z definir-diretório-seguro: verdadeiro
2026-10-26T16:41:21.2105700Z allow-unsafe-pr-checkout: false
2026-10-26T16:41:21.2106295Z ##[endgroup]
2026-10-26T16:41:21.2945733Z Sincronizando repositório: SERDESCONHECIDO/AnelDoArquiologo
2026-10-26T16:41:21.2948244Z ##[group]Obtendo informações da versão do Git
2026-10-26T16:41:21.2949286Z O diretório de trabalho é '/home/runner/work/AnelDoArquiologo/AnelDoArquiologo'
2026-10-26T16:41:21.2950632Z [comando]/usr/bin/git versão
2026-10-26T16:41:21.2951288Z versão git 2.55.0
2026-10-26T16:41:21.2960813Z ##[endgroup]
2026-10-26T16:41:21.2973304Z Substituindo temporariamente HOME='/home/runner/work/_temp/b6a50115-d6d8-4f3e-88b2-f4e9533de32d' antes de fazer alterações globais na configuração do git
2026-10-26T16:41:21.2974756Z Adicionando o diretório do repositório à configuração global temporária do Git como um diretório seguro.
2026-10-26T16:41:21.2976023Z [comando]/usr/bin/git config --global --add safe.directory /home/runner/work/AnelDoArquiologo/AnelDoArquiologo
2026-10-26T16:41:21.3071583Z Excluindo o conteúdo de '/home/runner/work/AnelDoArquiologo/AnelDoArquiologo'
2026-10-26T16:41:21.3073327Z ##[group]Inicializando o repositório
2026-10-26T16:41:21.3074469Z [comando]/usr/bin/git init /home/runner/work/AnelDoArquiologo/AnelDoArquiologo
2026-10-26T16:41:21.3167330Z dica: Usando 'master' como nome para a branch inicial. Este é o nome de branch padrão.
2026-10-26T16:41:21.3169158Z dica: mudará para "main" no Git 3.0. Para configurar o nome da branch inicial.
2026-10-26T16:41:21.3170702Z dica: para usar em todos os seus novos repositórios, o que suprimirá este aviso.
2026-10-26T16:41:21.3171837Z dica: chamada:
2026-10-26T16:41:21.3172516Z dica:
2026-10-26T16:41:21.3173354Z dica: git config --global init.defaultBranch <nome>
2026-10-26T16:41:21.3174285Z dica:
2026-10-26T16:41:21.3175153Z dica: Nomes comumente escolhidos em vez de 'master' são 'main', 'trunk' e
2026-10-26T16:41:21.3176485Z dica: 'desenvolvimento'. O branch recém-criado pode ser renomeado através deste comando:
2026-10-26T16:41:21.3177639Z dica:
2026-10-26T16:41:21.3178477Z dica: git branch -m <nome>
2026-10-26T16:41:21.3179205Z dica:
2026-10-26T16:41:21.3180120Z dica: Desative esta mensagem com "git config set advice.defaultBranchName false"
2026-10-26T16:41:21.3181902Z Repositório Git vazio inicializado em /home/runner/work/AnelDoArquiologo/AnelDoArquiologo/.git/
2026-10-26T16:41:21.3184381Z [comando]/usr/bin/git remote add origin https://github.com/SERDESCONHECIDO/AnelDoArquiologo
2026-10-26T16:41:21.3250135Z ##[endgroup]
2026-10-26T16:41:21.3251467Z ##[group]Desativando a coleta automática de lixo
2026-10-26T16:41:21.3252330Z [comando]/usr/bin/git config --local gc.auto 0
2026-10-26T16:41:21.3269718Z ##[endgroup]
2026-10-26T16:41:21.3270662Z ##[group]Configurando a autenticação
2026-10-26T16:41:21.3271531Z [comando]/usr/bin/git config --local --name-only --get-regexp core\.sshCommand
2026-10-26T16:41:21.3321312Z [comando]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'core\.sshCommand' && git config --local --unset-all 'core.sshCommand' || :"
2026-10-26T16:41:21.3788272Z [comando]/usr/bin/git config --local --name-only --get-regexp http\.https\:\/\/github\.com\/\.extraheader
2026-10-26T16:41:21.3831040Z [comando]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'http\.https\:\/\/github\.com\/\.extraheader' && git config --local --unset-all 'http.https://github.com/.extraheader' || :"
2026-10-26T16:41:21.4095080Z [comando]/usr/bin/git config --local --name-only --get-regexp ^includeIf\.gitdir:
2026-10-26T16:41:21.4126196Z [comando]/usr/bin/git submodule foreach --recursive git config --local --show-origin --name-only --get-regexp remote.origin.url
2026-10-26T16:41:21.4377526Z [comando]/usr/bin/git config --local http.https://github.com/.extraheader AUTORIZAÇÃO: básica ***
2026-10-26T16:41:21.4413096Z ##[endgroup]
2026-10-26T16:41:21.4413744Z ##[group]Obtendo o repositório
2026-10-26T16:41:21.4420683Z [comando]/usr/bin/git -c protocol.version=2 fetch --no-tags --prune --no-recurse-submodules --depth=1 origin +05ddb25f9f02416749eb8cc8d8f062de661c13a5:refs/remotes/origin/main
2026-10-26T16:41:21.6884930Z De https://github.com/SERDESCONHECIDO/AnelDoArquiologo
2026-10-26T16:41:21.6886806Z * [nova ref] 05ddb25f9f02416749eb8cc8d8f062de661c13a5 -> origem/principal
2026-10-26T16:41:21.6889552Z ##[endgroup]
2026-10-26T16:41:21.6890528Z ##[group]Determinando as informações de finalização da compra
2026-10-26T16:41:21.6892106Z ##[endgroup]
2026-10-26T16:41:21.6893745Z [comando]/usr/bin/git sparse-checkout disable
2026-10-26T16:41:21.6895586Z [comando]/usr/bin/git config --local --unset-all extensions.worktreeConfig
2026-10-26T16:41:21.6917480Z ##[group]Verificando a referência
2026-10-26T16:41:21.6921742Z [comando]/usr/bin/git checkout --progress --force -B main refs/remotes/origin/main
2026-10-26T16:41:21.6973371Z Mudou para uma nova ramificação 'principal'
2026-10-26T16:41:21.6974628Z branch 'main' set up to track 'origin/main'.
2026-10-26T16:41:21.6984787Z ##[endgroup]
2026-10-26T16:41:21.7034968Z [comando]/usr/bin/git log -1 --format=%H
2026-10-26T16:41:21.7058564Z 05ddb25f9f02416749eb8cc8d8f062de661c13a5
2026-10-26T16:41:21.7322749Z ##[group]Executar ações/setup-dotnet@v4
2026-10-26T16:41:21.7323627Z com:
2026-10-26T16:41:21.7324232Z versão do .NET: 6.0.x
2026-10-26T16:41:21.7325092Z cache: false
2026-10-26T16:41:21.7325705Z ##[grupo final]
2026-10-26T16:41:21.8506715Z (node:2225) [DEP0040] Aviso de obsolescência: O módulo `punycode` está obsoleto. Por favor, use uma alternativa de espaço do usuário.
2026-10-26T16:41:21.8585732Z (Use `node --trace-deprecation ...` para mostrar onde o aviso foi criado)
2026-10-26T16:41:21.8589697Z [comando]/home/runner/work/_actions/actions/setup-dotnet/v4/externals/install-dotnet.sh --skip-non-versioned-files --runtime dotnet --channel LTS
2026-10-26T16:41:22.0547600Z dotnet-install: Tentando baixar usando o link aka.ms https://builds.dotnet.microsoft.com/dotnet/Runtime/10.0.14/dotnet-runtime-10.0.14-linux-x64.tar.gz
2026-10-26T16:41:22.1902216Z dotnet-install: O arquivo remoto https://builds.dotnet.microsoft.com/dotnet/Runtime/10.0.14/dotnet-runtime-10.0.14-linux-x64.tar.gz tem 36673986 bytes.
2026-10-26T16:41:22.1904384Z dotnet-install: Extraindo o arquivo de https://builds.dotnet.microsoft.com/dotnet/Runtime/10.0.14/dotnet-runtime-10.0.14-linux-x64.tar.gz
2026-10-26T16:41:22.5980859Z dotnet-install: O tamanho do arquivo baixado é de 36673986 bytes.
2026-10-26T16:41:22.5982072Z dotnet-install: Os tamanhos dos arquivos remoto e local são iguais.
2026-10-26T16:41:22.6185168Z dotnet-install: A versão instalada é 10.0.14
2026-10-26T16:41:22.6263088Z dotnet-install: Adicionando ao PATH do processo atual: `/usr/share/dotnet`. Observação: esta alteração será visível somente ao executar o script.
2026-10-26T16:41:22.6264819Z dotnet-install: Observe que o script não resolve as dependências durante a instalação.
2026-10-26T16:41:22.6266671Z dotnet-install: Para verificar a lista de dependências, acesse https://learn.microsoft.com/dotnet/core/install, selecione seu sistema operacional e verifique a seção "Dependências".
2026-10-26T16:41:22.6268538Z dotnet-install: Instalação concluída com sucesso.
2026-10-26T16:41:22.6287244Z [comando]/home/runner/work/_actions/actions/setup-dotnet/v4/externals/install-dotnet.sh --skip-non-versioned-files --channel 6.0
2026-10-26T16:41:22.7954255Z dotnet-install: Tentando baixar usando o link aka.ms https://builds.dotnet.microsoft.com/dotnet/Sdk/6.0.428/dotnet-sdk-6.0.428-linux-x64.tar.gz
2026-10-26T16:41:23.2791627Z dotnet-install: O arquivo remoto https://builds.dotnet.microsoft.com/dotnet/Sdk/6.0.428/dotnet-sdk-6.0.428-linux-x64.tar.gz tem 188484831 bytes.
2026-10-26T16:41:23.2793646Z dotnet-install: Extraindo o arquivo de https://builds.dotnet.microsoft.com/dotnet/Sdk/6.0.428/dotnet-sdk-6.0.428-linux-x64.tar.gz
2026-10-26T16:41:25.5409585Z dotnet-install: O tamanho do arquivo baixado é de 188484831 bytes.
2026-10-26T16:41:25.5410177Z dotnet-install: Os tamanhos dos arquivos remoto e local são iguais.
2026-10-26T16:41:25.6589402Z dotnet-install: A versão instalada é 6.0.428
2026-10-26T16:41:25.6674556Z dotnet-install: Adicionando ao PATH do processo atual: `/usr/share/dotnet`. Observação: esta alteração será visível somente ao executar o script.
2026-10-26T16:41:25.6675701Z dotnet-install: Observe que o script não resolve as dependências durante a instalação.
2026-10-26T16:41:25.6676967Z dotnet-install: Para verificar a lista de dependências, acesse https://learn.microsoft.com/dotnet/core/install, selecione seu sistema operacional e verifique a seção "Dependências".
2026-10-26T16:41:25.6678230Z dotnet-install: Instalação concluída com sucesso.
2026-10-26T16:41:25.6838303Z ##[group]Execute git clone --depth 1 https://github.com/StardewModders/mod-reference-assemblies.git "$HOME/StardewValley"
2026-10-26T16:41:25.6839137Z [36;1mgit clone --depth 1 https://github.com/StardewModders/mod-reference-assemblies.git "$HOME/StardewValley" [0m
2026-10-26T16:41:25.7013272Z shell: /usr/bin/bash -e {0}
2026-10-26T16:41:25.7013547Z env:
2026-10-26T16:41:25.7013730Z DOTNET_ROOT: /usr/share/dotnet
2026-10-26T16:41:25.7013982Z ##[endgroup]
2026-10-26T16:41:25.7122304Z Clonando em '/home/runner/StardewValley'...
2026-10-26T16:41:26.0592734Z ##[group]Executar dotnet build AnelDoPescador.csproj -c Release
2026-10-26T16:41:26.0593151Z [36;1mdotnet build AnelDoPescador.csproj -c Release [0m
2026-10-26T16:41:26.0650404Z shell: /usr/bin/bash -e {0}
2026-10-26T16:41:26.0650654Z env:
2026-10-26T16:41:26.0650840Z DOTNET_ROOT: /usr/share/dotnet
2026-10-26T16:41:26.0651082Z ##[endgroup]
2026-10-26T16:41:28.3833825Z Determinando projetos para restaurar...
2026-10-26T16:41:28.9658577Z Restaurado /home/runner/work/AnelDoArquiologo/AnelDoArquiologo/AnelDoPescador.csproj (em 69 ms).
2026-10-26T16:41:30.7820687Z ##[erro]/home/runner/work/AnelDoArquiologo/AnelDoArquiologo/ModEntry.cs(130,2): erro CS1022: Esperava-se uma definição de tipo ou namespace, ou fim de arquivo [/home/runner/work/AnelDoArquiologo/AnelDoArquiologo/AnelDoPescador.csproj]
2026-10-26T16:41:30.7957012Z
2026-10-26T16:41:30.7961943Z Compilação FALHOU.
2026-10-26T16:41:30.7962224Z
2026-10-26T16:41:30.7964441Z ##[erro]/home/runner/work/AnelDoArquiologo/AnelDoArquiologo/ModEntry.cs(130,2): erro CS1022: Esperava-se uma definição de tipo ou namespace, ou fim de arquivo [/home/runner/work/AnelDoArquiologo/AnelDoArquiologo/AnelDoPescador.csproj]
2026-10-26T16:41:30.7966390Z 0 Aviso(s)
2026-10-26T16:41:30.7966655Z 1 Erro(s)
2026-10-26T16:41:30.7966807Z
2026-10-26T16:41:30.7966957Z Tempo decorrido: 00:00:03.39
2026-10-26T16:41:30.8135244Z ##[erro]Processo concluído com código de saída 1.
2026-10-26T16:41:30.8264677Z Limpeza pós-trabalho.
2026-10-26T16:41:30.8984534Z [comando]/usr/bin/git versão
2026-10-26T16:41:30.9022672Z versão git 2.55.0
2026-10-26T16:41:30.9054502Z Substituindo temporariamente HOME='/home/runner/work/_temp/298af061-31b1-4631-8e01-2bce8404f683' antes de fazer alterações globais na configuração do git
2026-10-26T16:41:30.9055741Z Adicionando o diretório do repositório à configuração global temporária do Git como um diretório seguro.
2026-10-26T16:41:30.9058718Z [comando]/usr/bin/git config --global --add safe.directory /home/runner/work/AnelDoArquiologo/AnelDoArquiologo
2026-10-26T16:41:30.9101613Z [comando]/usr/bin/git config --local --name-only --get-regexp core\.sshCommand
2026-10-26T16:41:30.9137816Z [comando]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'core\.sshCommand' && git config --local --unset-all 'core.sshCommand' || :"
2026-10-26T16:41:30.9401828Z [comando]/usr/bin/git config --local --name-only --get-regexp http\.https\:\/\/github\.com\/\.extraheader
2026-10-26T16:41:30.9425776Z http.https://github.com/.extraheader
2026-10-26T16:41:30.9435644Z [comando]/usr/bin/git config --local --unset-all http.https://github.com/.extraheader
2026-10-26T16:41:30.9490149Z [comando]/usr/bin/git submodule foreach --recursive sh -c "git config --local --name-only --get-regexp 'http\.https\:\/\/github\.com\/\.extraheader' && git config --local --unset-all 'http.https://github.com/.extraheader' || :"
2026-10-26T16:41:30.9763863Z [comando]/usr/bin/git config --local --name-only --get-regexp ^includeIf\.gitdir:
2026-10-26T16:41:30.9796706Z [comando]/usr/bin/git submodule foreach --recursive git config --local --show-origin --name-only --get-regexp remote.origin.url
2026-10-26T16:41:31.0240848Z Limpando processos órfãos
2026-10-26T16:41:31.0489525Z Encerrar processo órfão: pid (2682) (VBCSCompiler)
2026-10-26T16:41:31.0606973Z ##[aviso]O Node.js 20 está obsoleto. As seguintes ações são direcionadas ao Node.js 20, mas estão sendo forçadas a serem executadas no Node.js 24: actions/checkout@v4, actions/setup-dotnet@v4. Para mais informações, consulte: https://github.blog/changelog/2025-09-19-deprecation-of-node-20-on-github-actions-runners/
