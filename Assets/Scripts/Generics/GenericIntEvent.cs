using UnityEngine;

[CreateAssetMenu(menuName = "Generic int",fileName = "New Int",order = 1)]
public class GenericIntEvent : GameEvent<int>
{
    public int Value;
    
}
