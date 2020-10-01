using Assets.Scripts.Gameplay.Fuel;
using UnityEngine.Assertions;

namespace Assets.Scripts.Core.Spaceship
{
    public class SpaceshipModel
    {
        public FuelTank FuelTank { get; }
        public float StartFuelAmount = 100;
        public float MaxFuelAmount = 1000;

        public int CurrNumLives = 3;

        public SpaceshipModel()
        {
            Assert.IsTrue(StartFuelAmount <= MaxFuelAmount);
            Assert.IsTrue(StartFuelAmount > 0);

            FuelTank = new FuelTank(StartFuelAmount, MaxFuelAmount);
        }
    }
}
