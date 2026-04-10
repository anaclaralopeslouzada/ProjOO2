namespace LogSystem
{
    public class LegacyLogger
    {
        public void GravacaoRemota(string texto)
        {
            Console.WriteLine($"[LEGACY ADAPTER]: Enviando para servidor antigo -> {texto}");
        }
    }
}
