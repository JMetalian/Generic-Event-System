using System.Collections;
using System.Collections.Generic;
using Generics;
using UnityEngine;

[CreateAssetMenu(menuName = "Generic GameObject",fileName = "New GameObject",order = 6)]
public class GenericGameObjectEvent : InGameEvent<GameObject>
{
    public GameObject Object;
}

