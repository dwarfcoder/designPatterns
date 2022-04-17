using System.Text;
using DesignPatterns.Memento;
using dotnet6.Memento;

namespace DesignPatterns.Models;

public class Message : IMementoble<Message>
{
    public MessageType MessageType { get; set; }

    public string Title { get; set; }

    public string Body { get;set; }

    public IList<string> Recepients { get; set; } 

    public string Sender {get; set;}

    public Message() {
        Recepients = new List<string>();
        Sender = string.Empty;
        Title = string.Empty;
        Body = string.Empty;
    }

    public IMemento<Message> Save()
    {
        var cpMsg = (Message)this.MemberwiseClone();
        return new MessageMemento(cpMsg);
    }

    public void Restore(IMemento<Message> memento)
    {
        if(!(memento is MessageMemento))
        {
            throw new NotSupportedException($"{memento.ToString} is not supported");
        }

        MessageType = memento.GetState().MessageType;
        Title = memento.GetState().Title;
        Body = memento.GetState().Body;
        Recepients = memento.GetState().Recepients;
        Sender = memento.GetState().Sender;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("To: ").Append(GetRecepientsFormatted()).Append(Environment.NewLine)
            .Append(Title).Append(Environment.NewLine)
            .Append("From: ").Append(Sender).Append(Environment.NewLine).Append(Environment.NewLine)
            .Append(Body).Append(Environment.NewLine);

        return sb.ToString();
    }

    private string GetRecepientsFormatted() => String.Join(Environment.NewLine + "    ", Recepients);
}