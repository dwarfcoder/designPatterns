using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethod;

public class TextMessageSender : MessageSender
{
    // In real world app this class could contain an interface for Text Message Service to do a real job.
    // In this example I just implement output to console

    public override void Send(Message msg)
    {
        var recipients = string.Join(",", msg.Recepients);

        Console.WriteLine(nameof(TextMessageSender));
        Console.WriteLine($"From: {msg.Sender}");
        Console.WriteLine($"To: {recipients}");
        Console.WriteLine();
        Console.WriteLine(msg.Body);
    }
}