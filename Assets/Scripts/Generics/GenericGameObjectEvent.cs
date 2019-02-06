using System.Collections;
using System.Collections.Generic;
using Generics;
using UnityEngine;

[CreateAssetMenu(menuName = "GenericGameObjectEvent")]
public class GenericGameObjectEvent : InGameEvent<GameObject>
{
    public override void Raise(GameObject variable)
    {
        base.Raise(variable);
    }
}
