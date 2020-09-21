using Assets.Scripts.Gameplay.Fuel;
using UnityEngine;

namespace Assets.Scripts.Core.General
{
    public class MovementAction : Action, IMovingAdapter
    {
        public Rigidbody2D MovingBody { get; }
        public float MoveSpeed { get; set; }

        public MovementAction(FuelTank fuelTank, float consumeRate,
                                IMovingAdapter movingAdapter,
                                float moveSpeed) : base(fuelTank, consumeRate)
        {
            MovingBody = movingAdapter.MovingBody;
            MoveSpeed = moveSpeed;
        }

        protected override void Perform()
        {
            MovingBody.AddForce(MovingBody.transform.up * MoveSpeed);
        }
    }
}
