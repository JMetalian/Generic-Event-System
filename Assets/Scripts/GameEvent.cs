using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent<T> : ScriptableObject, IEventInterface<T>
{   

    public List<IListener<T>> listenersVar;

    private void OnEnable()
    {
        listenersVar = new List<IListener<T>>();
    }

    public void AddListener(IListener<T> listener)
    {
        if(!listenersVar.Contains(listener)) listenersVar.Add(listener);
    }
    public void RemoveListener(IListener<T> listener)
    {
        if(!listenersVar.Contains(listener)) listenersVar.Remove(listener);
        
    }
    public void Raise(T variable){
        for (int i = listenersVar.Count-1; i>=0; i--)
        {
            listenersVar[i].OnRaised(variable);
        }
    }
}