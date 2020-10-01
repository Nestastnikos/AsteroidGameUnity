using Assets.Scripts.Core.General;
using Assets.Scripts.Gameplay.Fuel;
using System;

namespace Assets.Scripts.Core.Spaceship
{
    public class SpaceshipMovementAction : MovementAction, IMovingRestrictedAdapter
    {
        public SpaceshipModel Spaceship { get; }
        public SpaceshipView State { get; }

        public static Action<float> OnFuelChange;

        public SpaceshipMovementAction(FuelTank fuelTank, float consumeRate,
                                        IMovingRestrictedAdapter movingAdapter,
                                        float moveSpeed) : base(fuelTank, consumeRate, movingAdapter, moveSpeed)
        {
            Spaceship = App.Models.Spaceship;
            State = movingAdapter.State;
        }

        protected override void Perform()
        {
            if(State.IsThrustEnabled)
            {
                base.Perform();
                OnFuelChange?.Invoke(Spaceship.FuelTank.CurrentAmount);
            }
        }
    }
}
