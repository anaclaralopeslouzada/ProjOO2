namespace LogSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Configura o Logger Real e os Observadores
            Logger realLogger = new Logger();
            
            var console = new ConsoleObserver();
            var legacy = new LegacyLogger();
            var adapter = new LogAdapter(legacy); 

            realLogger.Subscribe(console);
            realLogger.Subscribe(adapter);

            // Cria o Proxy para controlar o acesso
            LoggerProxy proxy = new LoggerProxy(realLogger);

            // Testes
            Console.WriteLine("--- Teste 1: Log Válido via Proxy ---");
            proxy.Log("Mensagem importante", 2);

            Console.WriteLine("\n--- Teste 2: Proxy Bloqueando Mensagem Vazia ---");
            proxy.Log("", 1);

            Console.WriteLine("\n--- Teste 3: Proxy Bloqueando Nível Inválido ---");
            proxy.Log("Teste", 99);
        }
    }
}
