using DesignPatterns.Models;

namespace DesignPatterns.Builder;

public class EmailMessageBuilder : IConcreteBuilder {
    private readonly MessageBuilder _builder = new MessageBuilder();

    public Message Construct() {
        _builder.Reset()
        .MessageType(MessageType.Email)
        .Body($@"This is a greeting email!
        This is a test message to demonstrate some things.
        I try to 'send' this message via different senders.")
        .Title("Hello")
        .Sender("Some guy")
        .AddRecipient("john@company.com")
        .AddRecipient("eva@company.com");

        return _builder.Build();
    }
}