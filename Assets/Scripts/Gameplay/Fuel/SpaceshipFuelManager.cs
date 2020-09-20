using UnityEngine;

namespace Assets.Scripts.Gameplay.Fuel
{
    public class SpaceshipFuelManager : MonoBehaviour
    {
        public float spaceshipFuel = 100;

        private bool HasEnoughFuel(float amount)
        {
            return spaceshipFuel >= amount;
        }

        public void SupplyFuel(float amount)
        {
            if(!HasEnoughFuel(amount))
            {
                throw new NotEnoughFuelException();
            }

            spaceshipFuel -= amount;
        }
    }
}
