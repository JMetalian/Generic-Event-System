public interface IEventInterface<T>
{
    void AddListener(IListener<T> listener);
    void RemoveListener(IListener<T> listener);
    void Raise(T variable);
}