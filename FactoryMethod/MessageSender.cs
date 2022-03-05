namespace DesignPatterns.FactoryMethod;

public abstract class MessageSender : IMessageSender
{
    public abstract void Send(Message msg);

    public Task SendAsync(Message msg) => Task.Run(() => Send(msg));
}