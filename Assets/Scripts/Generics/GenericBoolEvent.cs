using System.Collections;
using System.Collections.Generic;
using Generics;
using UnityEngine;

[CreateAssetMenu(menuName = "GenericBoolEvent")]
public class GenericBoolEvent : InGameEvent<bool>
{
    public override void Raise(bool variable)
    {
        base.Raise(variable);
    }
}
