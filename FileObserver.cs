using System;

namespace LogSystem
{
    // Outro Observador Concreto que simula a gravação do log em um arquivo
    public class FileObserver : ILogObserver
    {
        public void Update(string message)
        {
            // Implementação específica que simula a escrita em disco
            Console.WriteLine($"[FILE LOG]: Gravando no arquivo log.txt -> {message}");
        }
    }
}
