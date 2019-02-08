[System.Serializable]
public class IntReference : Reference<int, IntVariable>
{
    public IntReference() : base() { }
    public IntReference(int value) : base(value) { }
}