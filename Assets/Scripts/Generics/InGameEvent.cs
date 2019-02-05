namespace Generics
{
    public class InGameEvent<T> : GameEvent<T>
    {
        public override void Raise(T variable)
        {
            base.Raise(variable);
        }
    }
}