using System.Collections;
using System.Collections.Generic;
using Generics;
using UnityEngine;

[CreateAssetMenu(menuName = "GenericObjectEvent")]
public class GenericObjectEvent : InGameEvent<object>
{
    public override void Raise(object variable)
    {
        base.Raise(variable);
    }
}
