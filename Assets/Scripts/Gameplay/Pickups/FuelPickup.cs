using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Gameplay.Pickups
{
    public class FuelPickup : MonoBehaviour, IKillable
    {
        public PickupEffect effect;

        public void Die()
        {
            Destroy(gameObject);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            effect.Apply(collision.gameObject);
            Die();
        }
    }
}
