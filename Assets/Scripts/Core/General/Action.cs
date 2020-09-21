using Assets.Scripts.Gameplay.Fuel;
using UnityEngine;

namespace Assets.Scripts.Core.General
{
    public abstract class Action : IFuelConsumer
    {
        private float ConsumeRate { get; }
        private FuelTank FuelTank { get; }

        protected abstract void Perform();

        public void Consume()
        {
            FuelTank.Consume(ConsumeRate);
            Debug.Log(FuelTank.CurrentAmount);
        }

        public Action(FuelTank fuelTank, float consumeRate)
        {
            FuelTank = fuelTank;
            ConsumeRate = consumeRate;
        }

        public void Execute()
        {
            if(FuelTank.HasEnougToSupply(ConsumeRate))
            {
                Consume();
                Perform();
            }
        }
    }
}
