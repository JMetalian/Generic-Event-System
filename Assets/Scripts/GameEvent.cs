using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class GameEvent<T> : ScriptableObject, IEventInterface<T>
{   
    public Dictionary<Type,List<IListener<T>>> list = new Dictionary<Type, List<IListener<T>>>();
    public static List<IListener<T>> listenersVar;

    private void OnEnable()
    {
        listenersVar = new List<IListener<T>>();
    }

    public void AddListener(IListener<T> listener)
    {
        if (!list.ContainsKey(typeof(T)))
        {
            list.Add(typeof(T),new List<IListener<T>>());
        }
     
        list[typeof(T)].Add(listener);
        
        if(!listenersVar.Contains(listener)) listenersVar.Add(listener);
    }
    public void RemoveListener(IListener<T> listener)
    {
        if(!listenersVar.Contains(listener)) listenersVar.Remove(listener);
        
    }
    public virtual void Raise(T variable)
    {
        List<IListener<T>> listener;
        list.TryGetValue(variable.GetType(), out listener);
        listener.ForEach(listener1 => listener1.OnRaised(variable));
//        for (int i = listenersVar.Count-1; i>=0; i--)
//        {
//            listenersVar[i].OnRaised(variable);
//        }
    }
}