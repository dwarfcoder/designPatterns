using DesignPatterns.Models;

namespace DesignPatterns.Builder;

public class TextMessageBuilder : IConcreteBuilder {
    private readonly MessageBuilder _builder = new MessageBuilder();

    public Message Construct() {
        _builder.Reset()
        .MessageType(MessageType.Text)
        .Body($@"Hello from text!
        This is a test message to demonstrate some things.
        I try to 'send' this message via different senders.")
        .Sender("Some guy")
        .AddRecipient("john@company.com")
        .AddRecipient("eva@company.com");

        return _builder.Build();
    }    
}