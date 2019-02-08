using UnityEngine;

public abstract class Reference { }
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
    protected TT vari;

    public T Value
    {
        get { return useConst ? constVal : vari.Value; }
        set
        {
            if (!useConst && vari != null)
                vari.Value = value;
            else if (useConst)
                constVal = value;
        }
    }
    public void AddListener(IListener listener)
    {
        if (vari != null)
            vari.AddListener(listener);
    }
    public void RemoveListener(IListener listener)
    {
        if (vari != null)
            vari.RemoveListener(listener);
    }
//    public override string ToString()
//    {
//        return Value.ToString();
//    }
}
