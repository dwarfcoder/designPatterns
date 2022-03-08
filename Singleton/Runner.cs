using DesignPatterns.FactoryMethod;

namespace DesignPatterns.Singleton;

public class Runner : IRunner
{
    public async Task RunAsync()
    {
        Console.WriteLine();
        Console.WriteLine("***");
        Console.WriteLine(nameof(DesignPatterns.Singleton));
        var msg = MessageHelper.CreateDefaultMessage();
        var type = MessageType.Text;

        // Use our singleton
        IMessageSenderSelector selector = MessageSenderSelector.Instance;

        IMessageSender sender = selector.GetSender(type);
        await sender.SendAsync(msg);
    }
}
