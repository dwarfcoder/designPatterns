using DesignPatterns.FactoryMethod;
using DesignPatterns.Singleton;

namespace DesignPatterns.Builder;

public class Runner : IRunner
{
    public async Task RunAsync()
    {
        Console.WriteLine();
        Console.WriteLine("***");
        Console.WriteLine(nameof(DesignPatterns.Builder));

        IConcreteBuilder builder = new EmailMessageBuilder();
        var msg = builder.Construct();

        IMessageSenderSelector selector = MessageSenderSelector.Instance;
        IMessageSender sender = selector.GetSender(msg);
        await sender.SendAsync(msg);
    }
}
