using Assets.Scripts.Gameplay.Fuel;
using UnityEngine;

namespace Assets.Scripts.Core.General
{
    public class RotationAction : Action, IMovingAdapter
    {
        public Rigidbody2D MovingBody { get; }

        protected readonly float RotationAngle;

        public RotationAction(FuelTank fuelTank, float consumeRate,
                                IMovingAdapter movingAdapter,
                                float rotationAngle) : base(fuelTank, consumeRate)
        {
            MovingBody = movingAdapter.MovingBody;
            RotationAngle = rotationAngle;
        }

        protected override void Perform()
        {
            RotateBy(RotationAngle);
        }

        private void RotateBy(float angle)
        {
            var z = MovingBody.transform.rotation.eulerAngles.z + angle;
            MovingBody.transform.rotation = Quaternion.Euler(0, 0, z);
        }
    }
}
