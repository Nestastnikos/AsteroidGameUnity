using Assets.Scripts.Core.Spaceship;
using Assets.Scripts.Gameplay.Fuel;
using UnityEngine;

namespace Assets.Scripts.Gameplay.Pickups
{
    [CreateAssetMenu(fileName = "FuelPickup", menuName = "Feature/Create Fuel Pickup")]
    public class FuelPickupEffect : PickupEffect
    {
        public float Amount = 1000;
        public override void Apply(GameObject collider)
        {
            var fuelTank = App.Models.Spaceship.FuelTank;
            fuelTank.Refill(Amount);
        }
    }
}
