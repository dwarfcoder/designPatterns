using DesignPatterns.FactoryMethod;

namespace DesignPatterns.Singleton;

public sealed class MessageSenderSelector: IMessageSenderSelector {
    // The main difference between a static class and a singleton class is that the singleton
    // can implement implement interfaces or be inherited from base class.
    // Let's use this advantage

    private static readonly Lazy<MessageSenderSelector> lazy =
        new Lazy<MessageSenderSelector>(() => new MessageSenderSelector());

    // We need a private constructor to prevent object creation from user code
    private MessageSenderSelector() {
    }

    public static MessageSenderSelector Instance => lazy.Value;

    public IMessageSender GetSender(MessageType messageType) {

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