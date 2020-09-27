using Assets.Scripts.Gameplay.Fuel;
using Assets.Scripts.Interfaces;
using System;
using UnityEngine;
using UnityEngine.Assertions;

namespace Assets.Scripts.Core.Spaceship
{
    public class Spaceship : MonoBehaviour, IKillable
    {
        public bool IsThrustEnabled { get; set; }

        public FuelTank FuelTank { get; private set; }
        public float StartFuelAmount = 100;
        public float MaxFuelAmount = 1000;

        private PlayerRespawnAfterDeath respawner;
        private CircleCollider2D colliderRef;

        private int _currNumLives = 3;

        public static Action OnDestroyed;

        private void Awake()
        {
            Assert.IsTrue(StartFuelAmount <= MaxFuelAmount);
            Assert.IsTrue(StartFuelAmount > 0);

            FuelTank = new FuelTank(StartFuelAmount, MaxFuelAmount);
        }

        private void Start()
        {
            var rendererRef = GetComponentInChildren<SpriteRenderer>();
            colliderRef = GetComponent<CircleCollider2D>();
            respawner = new PlayerRespawnAfterDeath(colliderRef, rendererRef, gameObject);
        }

        public void Die()
        {
            colliderRef.enabled = false;
            _currNumLives--;
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
            if (_currNumLives > 0)
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
