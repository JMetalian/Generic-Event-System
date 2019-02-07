using UnityEngine;
using UnityEngine.Events;


public abstract class GameEventListener<T> : MonoBehaviour, IListener<T>
{
    protected GameEvent<T> ev,formerEv;
    private ScriptableObject Ev => ev;//GET

    private UnityEvent<T> returnedResp;
    private UnityEventBase Resp => returnedResp;//GET

    public void OnRaised(T t)
    {
        returnedResp.Invoke(t);
    }

    private void OnEnable()
    {
        if (ev != null) Subscribe();
    }

    private void OnDisable()
    {
        if (ev != null) ev.RemoveListener(this);
    }

    private void OnValidate()
    {
        if (ev != null) Subscribe();
    }

    private void Subscribe()
    {
        if (formerEv != null) formerEv.RemoveListener(this);

        ev.AddListener(this);
        formerEv = ev;
    }
}

public abstract class GameEventListener : MonoBehaviour, IListener
{
    private GameEvent ev,formerEv;
    private UnityEvent returnedResp;

    private ScriptableObject Ev => ev;//GET

    public UnityEvent Resp => returnedResp;//GET

    public void OnRaised()
    {
        returnedResp.Invoke();
    }
    private void OnEnable()
    {
        if (ev != null) Subscribe();
    }

    private void OnDisable()
    {
        if (ev != null) ev.RemoveListener(this);
    }

    private void OnValidate()
    {
        if (ev != null) Subscribe();
    }

    private void Subscribe()
    {
        if (formerEv != null) formerEv.RemoveListener(this);

        ev.AddListener(this);
        formerEv = ev;
    }
}//DONE- Will be checked