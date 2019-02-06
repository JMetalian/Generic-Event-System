using System.Collections;
using System.Collections.Generic;
using Generics;
using UnityEngine;

[CreateAssetMenu(menuName = "Generic bool",fileName = "New Bool",order = 3)]
public class GenericBoolEvent : InGameEvent<bool>
{
    public bool Value;
}
