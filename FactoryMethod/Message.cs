namespace DesignPatterns.FactoryMethod;

public class Message {
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
}