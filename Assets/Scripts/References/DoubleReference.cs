[System.Serializable]
public class DoubleReference : Reference<double, DoubleVariable>
{
    public DoubleReference() : base() { }
    public DoubleReference(double value) : base(value) { }
}