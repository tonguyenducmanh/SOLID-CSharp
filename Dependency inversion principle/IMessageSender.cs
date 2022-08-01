namespace Dependency_inversion_principle
{
    public interface IMessageSender
    {
        void SendMesage(IPerson person, string message);
    }
}