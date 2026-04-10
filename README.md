# Exercício de ProjOO - Evolução do Logger (Observer, Adapter e Proxy)

Esse repositório contém a evolução do exercício de Logger, integrando agora os padrões **Observer**, **Adapter** e **Proxy**, 
conforme a atividade passada pelo Prof. Fábio Fagundes Silveira no dia 10/04/2026.

## O que eu fiz no projeto:
Desta vez, o sistema ficou mais completo. Além de avisar os observadores (Observer), adicionei:
1. **Filtros de Nível:** Agora as mensagens têm prioridade (Info, Warning, Error).
2. **Validação (Proxy):** Criei um "segurança" para o Logger que não deixa passar mensagens vazias ou com níveis errados.
3. **Compatibilidade (Adapter):** Fiz um adaptador para conseguir usar um sistema de log antigo que o professor simulou, integrando ele na nossa estrutura nova.

## Estrutura dos arquivos:

- **ILogObserver.cs**: Interface que define o método de atualização com os níveis de log.
- **Logger.cs**: O sujeito principal que gerencia os inscritos.
- **LoggerProxy.cs**: A camada que valida os dados antes de enviar para o Logger real.
- **LogAdapter.cs**: A classe que "traduz" o log novo para o formato do sistema legado.
- **LegacyLogger.cs**: Simulação do código antigo que precisou ser adaptado.
- **ConsoleObserver.cs** e **FileObserver.cs**: Meus observadores que decidem o que imprimir com base no nível do log.
- **Program.cs**: Onde eu testei todos os cenários, incluindo os bloqueios do Proxy e a integração do Adapter.

## Como rodar o código:
O repositório já contém o arquivo de projeto (`.csproj`). Para executar, basta abrir a pasta no terminal e digitar:

```bash
dotnet run
