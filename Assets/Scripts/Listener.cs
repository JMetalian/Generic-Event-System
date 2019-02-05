using UnityEngine;

public class Listener : MonoBehaviour
{
    private GameEventListener eventListener = new GameEventListener();

    public void OnRaised(Listener t)
    {
    }
}