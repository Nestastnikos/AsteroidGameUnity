using Assets.Scripts.Core.General;
using Assets.Scripts.Gameplay.Fuel;

namespace Assets.Scripts.Core.Spaceship
{
    public class SpaceshipMovementAction : MovementAction, IMovingRestrictedAdapter
    {
        public SpaceshipState State { get; }

        public SpaceshipMovementAction(FuelTank fuelTank, float consumeRate,
                                        IMovingRestrictedAdapter movingAdapter,
                                        float moveSpeed) : base(fuelTank, consumeRate, movingAdapter, moveSpeed)
        {
            State = movingAdapter.State;
        }

        protected override void Perform()
        {
            if(State.IsThrustEnabled)
            {
                base.Perform();
            }
        }
    }
}
