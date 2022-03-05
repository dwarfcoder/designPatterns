using System.Text;

public class TextMessageSender : IMessageSender
{
    // In real world app this class could contain an interface for Text Message Service to do a real job.
    // In this example I just implement output to console

    public void Send(Message msg)
    {
        var recipients = string.Join(",", msg.Recepients);

        Console.WriteLine($"From: {msg.Sender}");
        Console.WriteLine($"To: {recipients}");
        Console.WriteLine(msg.Title);
        Console.WriteLine();
        Console.WriteLine(msg.Body);

    }

    public Task SendAsync(Message msg) => Task.Run(() => Send(msg));
}