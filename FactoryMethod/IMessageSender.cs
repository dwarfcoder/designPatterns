using DesignPatterns.Models;

namespace DesignPatterns.FactoryMethod;

public interface IMessageSender {
    void Send(Message msg);

    Task SendAsync(Message msg);
}