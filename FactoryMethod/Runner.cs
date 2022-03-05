namespace DesignPatterns.FactoryMethod;

public class Runner : IRunner
{
    public void Run()
    {
        var msg = MessageHelper.CreateDefaultMessage();
        var type = MessageType.Email;

        IMessageSender sender = MessageHelper.GetSender(type);
        sender.Send(msg);        
    }
}
