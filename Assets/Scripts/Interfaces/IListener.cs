public interface IListener<T>
{
    void OnRaised(T t);
}
public interface IListener
{
    void OnRaised();
}//DONE