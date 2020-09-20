using Assets.Scripts.Gameplay.Fuel;
using UnityEngine;

namespace Assets.Scripts.Gameplay
{
    class SpaceshipActionManager : MonoBehaviour
    {
        private SpaceshipFuelManager fuelManager;
        private SpaceshipMovementManager movementManager;

        private readonly float MoveFuelAmount = 0.10f;
        private readonly float RotateFuelAmount = 0.10f;

        public void Start()
        {
            fuelManager = GetComponent<SpaceshipFuelManager>();
            movementManager = GetComponent<SpaceshipMovementManager>();
        }

        public void TryMoveForward()
        {
            try
            {
                fuelManager.SupplyFuel(MoveFuelAmount);
                movementManager.MoveForward();
            }
            catch(NotEnoughFuelException e)
            {
                Debug.LogError("Not enough fuel for moving!");
            }
        }

        public void TryTurnRight()
        {
            try
            {
                fuelManager.SupplyFuel(RotateFuelAmount);
                movementManager.TurnRight();
            }
            catch (NotEnoughFuelException e)
            {
                Debug.LogError("Not enough fuel for rotation!");
            }
        }

        public void TryTurnLeft()
        {
            try
            {
                fuelManager.SupplyFuel(RotateFuelAmount);
                movementManager.TurnLeft();
            }
            catch (NotEnoughFuelException e)
            {
                Debug.LogError("Not enough fuel for rotation!");
            }
        }
    }
}
