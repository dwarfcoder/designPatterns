using DesignPatterns.Builder;
using DesignPatterns.Models;
using DesignPatterns.Singleton;

namespace DesignPatterns.FactoryMethod;

public class Runner : IRunner
{
    public async Task RunAsync()
    {
        Console.WriteLine();
        Console.WriteLine("***");
        Console.WriteLine(nameof(DesignPatterns.FactoryMethod));
        IConcreteBuilder builder = new EmailMessageBuilder();
        var msg = builder.Construct();

        IMessageSenderSelector selector = MessageSenderSelector.Instance;
        IMessageSender sender = selector.GetSender(msg);
        await sender.SendAsync(msg);
    }
}
