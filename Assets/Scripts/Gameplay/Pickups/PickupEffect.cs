using UnityEngine;

namespace Assets.Scripts.Gameplay.Pickups
{
    abstract public class PickupEffect : ScriptableObject
    {
        abstract public void Apply(GameObject collider);
    }
}

