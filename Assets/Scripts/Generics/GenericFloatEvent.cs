using Generics;
using UnityEngine;

[CreateAssetMenu(menuName = "GenericFloatEvent")]
public class GenericFloatEvent : InGameEvent<float>
{
    public override void Raise(float variable)
    {
        base.Raise(variable);
    }
}