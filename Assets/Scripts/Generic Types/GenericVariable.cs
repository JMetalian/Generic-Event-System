using UnityEngine;

public abstract class GenericVariable : GameEvent
{
    public abstract System.Type Type { get; }
    public abstract object BaseValue { get; set; }
}
public abstract class GenericVariable<T> : GenericVariable
{
    public virtual T Value
    {
        get
        {
            return val;
        }
        set
        {
            val = SetValue(value);
            Raise();
        }
    }
    public override System.Type Type { get { return typeof(T); } }
    public override object BaseValue
    {
        get
        {
            return val;
        }
        set
        {
            val = SetValue((T)value);
            Raise();
        }
    }

    [SerializeField]
    protected T val;
    public virtual T SetValue(T value)
    {
        return value;
    }
    public virtual T SetValue(GenericVariable<T> value)
    {
        return value.Value;
    }
    
    // public override string ToString()
    // {
    //     return val == null ? "null" : val.ToString();
    // }
    public static implicit operator T(GenericVariable<T> variable)
    {
        return variable.Value;
    }
}