using DesignPatterns.FactoryMethod;
using DesignPatterns.Models;

namespace DesignPatterns.Singleton;

public interface IMessageSenderSelector {
    IMessageSender GetSender(Message message);
}