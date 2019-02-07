using UnityEngine;

[System.Serializable]
public abstract class Reference<T, TT> : Reference where TT : GenericVariable<T>
{
    public Reference() { }
    public Reference(T para)
    {
        useConst = true;
        constVal = para;
    }

    [SerializeField]
    protected bool useConst = false;
    [SerializeField]
    protected T constVal;
    [SerializeField]
    protected TT _variable;

    public T Value
    {
        get { return useConst ? constVal : _variable.Value; }
        set
        {
            if (!useConst && _variable != null)
                _variable.Value = value;
            else if (useConst)
                constVal = value;
        }
    }
    public void AddListener(IListener listener)
    {
        if (_variable != null)
            _variable.AddListener(listener);
    }
    public void RemoveListener(IListener listener)
    {
        if (_variable != null)
            _variable.RemoveListener(listener);
    }
    public override string ToString()
    {
        return Value.ToString();
    }
}
public abstract class Reference { }