using Assets.Scripts.Core.General;
using Assets.Scripts.Gameplay.Fuel;

namespace Assets.Scripts.Core.Spaceship
{
    public class MovementManager : IMovementManager
    {
        private MovementAction movementAction { get; }
        private RotationAction leftRotationAction { get; }
        private RotationAction rightRotationAction { get; }

        public MovementManager(IMovingRestrictedAdapter movingRestrictedAdapter, FuelTank fuelTank)
        {
            movementAction = new SpaceshipMovementAction(fuelTank, 0.10f, movingRestrictedAdapter, 1.0f);
            leftRotationAction = RotationActionFactory.CreateLeftRotationAction(movingRestrictedAdapter, fuelTank);
            rightRotationAction = RotationActionFactory.CreateRightRotationAction(movingRestrictedAdapter, fuelTank);
        }

        public void TryMoveForward()
        {
            movementAction.Execute();
        }

        public void TryTurnLeft()
        {
            leftRotationAction.Execute();
        }

        public void TryTurnRight()
        {
            rightRotationAction.Execute();
        }
    }
}
