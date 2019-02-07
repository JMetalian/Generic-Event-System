using System;
using UnityEngine;

public abstract class GameVariable<T> : GameVariable
{
    [SerializeField] protected T val;

    public virtual T Value
    {
        get => val;
        set
        {
            val = SetValue(value);
            Raise();
        }
    }

    public override Type Type => typeof(T);

    public override object BaseValue
    {
        get => val;
        set
        {
            val = SetValue((T) value);
            Raise();
        }
    }

    public virtual T SetValue(T value)
    {
        return value;
    }

    public virtual T SetValue(GameVariable<T> value)
    {
        return value.Value;
    }

    public static implicit operator T(GameVariable<T> para)
    {
        return para.Value;
    }
}

public abstract class GameVariable : GameEvent
{
    public abstract Type Type { get; }
    public abstract object BaseValue { get; set; }
}