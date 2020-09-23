using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Core.Spaceship
{
    public class PlayerDeathOnCollision : MonoBehaviour, IKillable
    {
        private PlayerRespawnAfterDeath respawner;
        private CircleCollider2D colliderRef;

        private void Start()
        {
            colliderRef = GetComponent<CircleCollider2D>();
            var rendererRef = GetComponentInChildren<SpriteRenderer>();
            respawner = new PlayerRespawnAfterDeath(colliderRef, rendererRef, gameObject);
        }
        public void Die()
        {
            colliderRef.enabled = false;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (IsTriggeredByAsteroid(collision))
            {
                Die();
                RespawnOnNewPosition();
            }
        }

        private void RespawnOnNewPosition()
        {
            StartCoroutine(respawner.Respawn());
        }

        private static bool IsTriggeredByAsteroid(Collider2D collision)
        {
            return collision.gameObject.layer == LayerMask.NameToLayer("Asteroids");
        }
    }
}
