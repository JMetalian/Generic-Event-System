using UnityEngine;

[CreateAssetMenu(menuName = "GenericIntEvent")]
public class GenericIntEvent : GameEvent<int>
{
    public override void Raise(int variable)
    {
        base.Raise(variable);
    }
}