using System.Collections;
using System.Collections.Generic;
using Generics;
using UnityEngine;

[CreateAssetMenu(menuName = "Generic Object",fileName = "New Object",order = 5)]
public class GenericObjectEvent : InGameEvent<object>
{
  public UnityEngine.Object Object;
    
}
