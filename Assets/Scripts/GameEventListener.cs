using UnityEngine;
using UnityEngine.Events;


public class GameEventListener : MonoBehaviour,IListener<Listener>
{
    
    public GameEvent<Listener> ev;
    public UnityEvent<Listener> invokeThis;

    private void OnEnable()
    {ev.AddListener(this);}

    private void OnDisable()
    {ev.RemoveListener(this);}

    public void OnRaised(Listener t)
    {invokeThis.Invoke(t);}
    
}