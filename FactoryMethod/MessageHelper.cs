namespace DesignPatterns.FactoryMethod;

public static class MessageHelper {
    public static Message CreateDefaultMessage() {
        var builder = new MessageBuilder();

        builder
        .Body($@"Hi everyone!
        This is a test message to demonstrate some things.
        I try to 'send' this message via different senders.")
        .Title("Hello, world!")
        .Sender("Some guy")
        .AddRecipient("john@company.com")
        .AddRecipient("eva@company.com");

        return builder.Build();
    }

    public static IMessageSender GetSender(MessageType messageType) {

        switch(messageType) {
            case MessageType.Email:
                return new EmailMessageSender();
            case MessageType.Text:
            return new TextMessageSender();
        }

        // throw an exception if message sender could not be created
        throw new ArgumentException(nameof(messageType));
    }
}