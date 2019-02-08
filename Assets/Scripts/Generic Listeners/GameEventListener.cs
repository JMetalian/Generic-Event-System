using UnityEngine;
using UnityEngine.Events;

public abstract class GameEventListener<T,GenericEvent,GenericResponse> : MonoBehaviour, IListener<T>
    where GenericEvent : GameEvent<T>
    where GenericResponse : UnityEvent<T>
{
    
    private ScriptableObject Ev => ev;//GET
    private UnityEventBase Resp => returnedResp;//GET

    

    private GenericEvent ev;
  
    private GenericEvent formerEv;
    [SerializeField]
    private GenericResponse returnedResp;

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

public abstract class GameEventListener<GenericEvent,GenericResponse> : MonoBehaviour, IListener
where GenericEvent : GameEvent
where GenericResponse : UnityEvent
{    
    private ScriptableObject GameEvent => ev;//GET

    public UnityEvent Response => returnedResp;//GET
    
    
    private GenericEvent ev;
    
    private GenericEvent formerEv;
    [SerializeField]
    private GenericResponse returnedResp;



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