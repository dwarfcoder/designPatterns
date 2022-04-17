using System;
using DesignPatterns.Memento;
using DesignPatterns.Models;
using dotnet6.Models;

namespace dotnet6.Memento;

public class CareTaker
{
	private readonly MyQueue<IMemento<Message>> _mementos = new MyQueue<IMemento<Message>>();

	private readonly Message _message;

	public CareTaker(Message message)
	{
		_message = message;
	}

	public void Backup()
    {
		_mementos.Enqueue(_message.Save());
		Console.WriteLine("Message backed up");
    }

	public void Undo()
    {
		if(_mementos.Count == 0)
        {
			return;
        }

		var memento = _mementos.Dequeue();

        try
        {
			_message.Restore(memento);
        }
		catch(NotSupportedException nse)
        {
			Undo();
        }
    }

	public IEnumerable<Message> GetHistory => _mementos.Items.Select(x => x.GetState()).AsEnumerable();
}
