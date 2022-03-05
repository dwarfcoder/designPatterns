namespace DesignPatterns.FactoryMethod;

public class MessageBuilder {
    private Message msg;

    public MessageBuilder() {
        this.msg = new Message();
    }

    public MessageBuilder Title(string title) {
        msg.Title = title;
        return this;
    }

    public MessageBuilder Body(string body) {
        msg.Body = body;
        return this;
    }

    public MessageBuilder Recipients(IList<string> recipients) {
        msg.Recepients = recipients;
        return this;
    }

    public MessageBuilder AddRecipient(string recipient) {
        msg.Recepients.Add(recipient);
        return this;
    }

    public MessageBuilder Sender(string sender) {
        msg.Sender = sender;
        return this;
    }

    public Message Build() => this.msg;
}