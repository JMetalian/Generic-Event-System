using System.Collections.Generic;
using UnityEngine;


public abstract class GameEvent<T> : ScriptableObject, IGameEvent<T>
{
    public static List<IListener<T>> listenersVar;
   
    private void OnEnable()
    {
        listenersVar = new List<IListener<T>>();
    }

    public void AddListener(IListener<T> listener)
    {
        if (!listenersVar.Contains(listener)) listenersVar.Add(listener);
    }

    public void RemoveListener(IListener<T> listener)
    {
        if (listenersVar.Contains(listener)) listenersVar.Remove(listener);
    }

    public virtual void Raise(T variable)
    {
        for (int i = listenersVar.Count-1; i>=0; i--)
        {
            listenersVar[i].OnRaised(variable);
        }
    }
}
public abstract class GameEvent: ScriptableObject,IGameEvent
{
    public static List<IListener> listenersVar=new List<IListener>();

    public void AddListener(IListener listener){
        if(!listenersVar.Contains(listener)) listenersVar.Add(listener);
    }
    public void RemoveListener(IListener listener){
        if(listenersVar.Contains(listener)) listenersVar.Remove(listener);
    }
    public void Raise(){
        for (int i = listenersVar.Count; i >= 0; i--)
        {
            listenersVar[i].OnRaised();
        }
    }

}
//Will be checked - DONE