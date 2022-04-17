using DesignPatterns.Memento;

namespace dotnet6.Memento;

public interface IMementoble<T>
{
	IMemento<T> Save();

	void Restore(IMemento<T> memento);
}

