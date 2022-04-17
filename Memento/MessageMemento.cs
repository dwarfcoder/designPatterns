using DesignPatterns.Models;

namespace DesignPatterns.Memento;

public class MessageMemento : IMemento<Message> {
    private readonly Message _state;

    public MessageMemento(Message msg)
    {
        _state = msg;
    }

    public Message GetState() {
        return _state;
    }
}