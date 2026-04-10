using System;

namespace LogSystem
{
    // Um Observador Concreto que reage ao log exibindo-o no console
    public class ConsoleObserver : ILogObserver
    {
        public void Update(string message)
        {
            // Implementação específica para saída via terminal
            Console.WriteLine($"[CONSOLE LOG]: {message}");
        }
    }
}
