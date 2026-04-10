namespace LogSystem
{
    public class LoggerProxy
    {
        private readonly Logger _realLogger;

        public LoggerProxy(Logger logger)
        {
            _realLogger = logger;
        }

        public void Log(string message, int level)
        {
            // Regra do Proxy: Não deixa logar mensagens vazias ou níveis inválidos
            if (string.IsNullOrWhiteSpace(message))
            {
                Console.WriteLine("[PROXY]: Bloqueado - Mensagem vazia.");
                return;
            }

            if (level < 1 || level > 3)
            {
                Console.WriteLine("[PROXY]: Bloqueado - Nível de log inválido.");
                return;
            }

            // Se estiver tudo OK, ele repassa para o Logger real
            _realLogger.Log(message, level);
        }
    }
}
