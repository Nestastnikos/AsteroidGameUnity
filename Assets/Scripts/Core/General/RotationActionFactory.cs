using Assets.Scripts.Gameplay.Fuel;

namespace Assets.Scripts.Core.General
{
    public class RotationActionFactory
    {
        public static RotationAction CreateLeftRotationAction(IMovingAdapter movingAdapter, FuelTank fuelTank)
        {
            var leftRotation = new RotationAction(fuelTank, 0.10f, movingAdapter, 3f);
            return leftRotation;
        }

        public static RotationAction CreateRightRotationAction(IMovingAdapter movingAdapter, FuelTank fuelTank)
        {
            var rightRotation = new RotationAction(fuelTank, 0.10f, movingAdapter, -3f);
            return rightRotation;
        }
    }
}
