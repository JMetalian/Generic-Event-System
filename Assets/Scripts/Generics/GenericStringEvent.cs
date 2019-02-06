using System.Collections;
using System.Collections.Generic;
using Generics;
using UnityEngine;
[CreateAssetMenu(menuName = "GenericStringEvent")]
public class GenericStringEvent : InGameEvent<string>
{
    public override void Raise(string variable)
    {
        base.Raise(variable);
    }
}
