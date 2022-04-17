namespace DesignPatterns.Memento;

public interface IMemento<out T> {
    T GetState();
}