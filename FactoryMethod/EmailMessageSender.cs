namespace DesignPatterns.FactoryMethod;

public sealed class EmailMessageSender : MessageSender
{
    // Here is just an example. In real world app you shoud inject and use
    // some sort of TcpClient or something. We'll talk about it later

    public override void Send(Message msg)
    {
        var recipients = string.Join(",", msg.Recepients);

        Console.WriteLine(nameof(EmailMessageSender));
        Console.WriteLine($"From: {msg.Sender}");
        Console.WriteLine($"To: {recipients}");
        Console.WriteLine(msg.Title);
        Console.WriteLine();
        Console.WriteLine(msg.Body);
    }
}