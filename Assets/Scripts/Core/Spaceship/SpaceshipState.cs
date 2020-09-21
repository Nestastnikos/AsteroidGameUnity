using Assets.Scripts.Gameplay.Fuel;
using UnityEngine;
using UnityEngine.Assertions;

namespace Assets.Scripts.Core.Spaceship
{
    public class SpaceshipState : MonoBehaviour
    {
        public bool IsThrustEnabled { get; set; }
        public FuelTank FuelTank { get; private set; }

        public float StartFuelAmount = 100;
        public float MaxFuelAmount = 1000;

        private void Awake()
        {
            Assert.IsTrue(StartFuelAmount <= MaxFuelAmount);
            Assert.IsTrue(StartFuelAmount > 0);

            FuelTank = new FuelTank(StartFuelAmount, MaxFuelAmount);
        }
    }
}
