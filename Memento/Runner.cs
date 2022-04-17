using DesignPatterns.Builder;
using DesignPatterns.FactoryMethod;
using DesignPatterns.Singleton;
using dotnet6.Memento;

namespace DesignPatterns.Memento;

public class Runner : IRunner
{
    public async Task RunAsync()
    {
        Console.WriteLine();
        Console.WriteLine("***");
        Console.WriteLine(nameof(DesignPatterns.Memento));

        // Instantiation (with help of the Builder pattern)
        IConcreteBuilder builder = new EmailMessageBuilder();
        var msg = builder.Construct();
        Console.WriteLine("Message built");

        // Now let's make some changes to our Message object.
        var careTaker = new CareTaker(msg);
        careTaker.Backup();

        Console.WriteLine("Let's update the Message");

        msg.Title = "Chanhed title";
        msg.Sender = "Some Wrong Sender";
        msg.Body = "I decided to change content of this message";
        careTaker.Backup();

        msg.Title = "Ok, this is the last edit";
        msg.Body = "I decided to change content of this message because... Just... you know... Because this is how it goes";
        careTaker.Backup();

        msg.Title = "Not, here is the last one";
        msg.Body = "Well, hmmm... That one was not that good though";
        careTaker.Backup();

        Console.WriteLine();
        Console.WriteLine("Undo changes");
        Console.WriteLine("History:");
        Console.WriteLine(string.Join(Environment.NewLine + "***" + Environment.NewLine, careTaker.GetHistory));
        careTaker.Undo();

        Console.WriteLine("Undo changes");
        Console.WriteLine("History:");
        Console.WriteLine(string.Join(Environment.NewLine + "***" + Environment.NewLine, careTaker.GetHistory));
        careTaker.Undo();

        Console.WriteLine("Undo changes");
        Console.WriteLine("History:");
        Console.WriteLine(string.Join(Environment.NewLine + "***" + Environment.NewLine, careTaker.GetHistory));
        careTaker.Undo();

        // Now we are ready to send it
        IMessageSenderSelector selector = MessageSenderSelector.Instance;
        IMessageSender sender = selector.GetSender(msg);
        await sender.SendAsync(msg);
    }
}
