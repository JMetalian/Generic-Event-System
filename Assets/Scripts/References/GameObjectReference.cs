using UnityEngine;

[System.Serializable]
public class GameObjectReference : Reference<GameObject, GameObjectVariable>
{
    public GameObjectReference() : base() { }
    public GameObjectReference(GameObject value) : base(value) { }
}