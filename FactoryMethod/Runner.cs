namespace DesignPatterns.FactoryMethod;

public class Runner : IRunner
{
    public async Task RunAsync()
    {
        var msg = MessageHelper.CreateDefaultMessage();
        var type = MessageType.Email;

        IMessageSender sender = MessageHelper.GetSender(type);
        await sender.SendAsync(msg);
    }
}
