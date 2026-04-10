namespace LogSystem
{
    // Esta interface define o contrato para os Observadores
    // Qualquer classe que queira "ouvir" os logs deve implementar esta interface
    public interface ILogObserver
    {
        // Método chamado pelo Subject sempre que houver uma nova mensagem
        void Update(string message);
    }
}
