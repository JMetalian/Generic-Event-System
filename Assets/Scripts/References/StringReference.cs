[System.Serializable]
public class StringReference : Reference<string, StringVariable>
{
    public StringReference() : base() { }
    public StringReference(string value) : base(value) { }
}