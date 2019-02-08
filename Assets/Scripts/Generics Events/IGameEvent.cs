public interface IGameEvent<T>
{
    void AddListener(IListener<T> listener);
    void RemoveListener(IListener<T> listener);
    void Raise(T variable);
    
}
public interface IGameEvent
{
    
    void AddListener(IListener listener);
    void RemoveListener(IListener listener);
    void Raise();
}//DONE