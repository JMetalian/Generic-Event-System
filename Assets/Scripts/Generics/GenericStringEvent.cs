using System.Collections;
using System.Collections.Generic;
using Generics;
using UnityEngine;

[CreateAssetMenu(menuName = "Generic String",fileName = "New String",order = 4)]
public class GenericStringEvent : InGameEvent<string>
{
    public string str;   
}
