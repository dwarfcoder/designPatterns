using DesignPatterns.Builder;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Models;

namespace DesignPatterns.Singleton;

public class Runner : IRunner
{
    public async Task RunAsync()
    {
        Console.WriteLine();
        Console.WriteLine("***");
        Console.WriteLine(nameof(DesignPatterns.Singleton));
        IConcreteBuilder builder = new TextMessageBuilder();
        var msg = builder.Construct();

        // Use our singleton
        IMessageSenderSelector selector = MessageSenderSelector.Instance;

        IMessageSender sender = selector.GetSender(msg);
        await sender.SendAsync(msg);
    }
}
