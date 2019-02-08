[System.Serializable]
public  class BoolReference : Reference<bool, BoolVariable>
{
    public BoolReference() : base() { }
    public BoolReference(bool value) : base(value) { }
}