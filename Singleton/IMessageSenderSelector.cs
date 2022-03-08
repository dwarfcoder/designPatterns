using DesignPatterns.FactoryMethod;

namespace DesignPatterns.Singleton;

public interface IMessageSenderSelector {
    IMessageSender GetSender(MessageType messageType);
}