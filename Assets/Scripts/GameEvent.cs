﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : ScriptableObject
{
    private List<GameEventListener> listeners= new List<GameEventListener>();

    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
        
    }
    public void RegisterListener(GameEventListener listener)
    {
        if (!listeners.Contains(listener))
        {
            listeners.Add(listener);
        }
    }

    public void DeRegisterListener(GameEventListener listener)
    {
         if (listeners.Contains(listener))
        {
            listeners.Remove(listener);
        }
    }
}