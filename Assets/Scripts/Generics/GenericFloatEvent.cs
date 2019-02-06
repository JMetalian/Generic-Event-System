using Generics;
using UnityEngine;

[CreateAssetMenu(menuName = "Generic float",fileName = "New Float",order = 2)]
public class GenericFloatEvent : InGameEvent<float>
{
    [SerializeField]
    private float Value;
}
