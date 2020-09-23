using UnityEngine;

namespace Assets.Scripts.Core.Spaceship
{
    public interface IRespawner
    {
        CircleCollider2D colliderRef { get; }
        SpriteRenderer rendererRef { get; }
        GameObject gameObject { get; }
    }
}