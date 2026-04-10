namespace LogSystem
{
    public class LogAdapter : ILogObserver
    {
        private readonly LegacyLogger _legacyLogger;

        public LogAdapter(LegacyLogger legacyLogger)
        {
            _legacyLogger = legacyLogger;
        }

        public void Update(string message, int level)
        {
            _legacyLogger.GravacaoRemota(message);
        }
    }
}
