[System.Serializable]
public class FloatReference : Reference<float, FloatVariable>
{
    public FloatReference() : base() { }
    public FloatReference(float value) : base(value) { }
}