using UnityEngine;

[System.Serializable]
public class ObjectReference : Reference<object, ObjectVariable>
{
    public ObjectReference() : base() { }
    public ObjectReference(Object value) : base(value) { }
}