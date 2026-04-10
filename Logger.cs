using System.Collections.Generic;

namespace LogSystem
{
    // O Sujeito mantém a lista de observadores e os notifica.
    // Ele não conhece os detalhes de como o log é processado 
    public class Logger
    {
        // Estrutura de dados que armazena os observadores registrados
        private readonly List<ILogObserver> _observers = new List<ILogObserver>();

        // Método para registrar um novo observador na lista
        public void Subscribe(ILogObserver observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        // Método para remover um observador da lista
        public void Unsubscribe(ILogObserver observer)
        {
            _observers.Remove(observer);
        }

        // Este método percorre a lista e avisa todos os observadores 
        public void Log(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
    }
}
