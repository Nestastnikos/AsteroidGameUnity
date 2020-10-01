using Assets.Scripts.Gameplay.Fuel;
using Assets.Scripts.Interfaces;
using System;
using UnityEngine;
using UnityEngine.Assertions;

namespace Assets.Scripts.Core.Spaceship
{
    public class SpaceshipView : MonoBehaviour, IKillable
    {
        public bool IsThrustEnabled { get; set; }

        private PlayerRespawnAfterDeath respawner;
        private CircleCollider2D colliderRef;

        public static Action OnDestroyed;

        private void Start()
        {
            var rendererRef = GetComponentInChildren<SpriteRenderer>();
            colliderRef = GetComponent<CircleCollider2D>();
            respawner = new PlayerRespawnAfterDeath(colliderRef, rendererRef, gameObject);
        }

        public void Die()
        {
            colliderRef.enabled = false;
            App.Models.Spaceship.CurrNumLives--;
            OnDestroyed?.Invoke();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!IsTriggeredByAsteroid(collision))
            {
                return;
            }

            Die();
            RespawnOrDestroy();
        }
        private static bool IsTriggeredByAsteroid(Collider2D collision)
        {
            return collision.gameObject.layer == LayerMask.NameToLayer("Asteroids");
        }

        private void RespawnOrDestroy()
        {
            if (App.Models.Spaceship.CurrNumLives > 0)
            {
                RespawnOnNewPosition();
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void RespawnOnNewPosition()
        {
            StartCoroutine(respawner.Respawn());
        }

    }
}
