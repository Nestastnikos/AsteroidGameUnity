namespace Assets.Scripts.Gameplay.Fuel
{
    public class FuelTank
    {
        public float MaxAmount { get; }
        public float CurrentAmount { get; private set; }

        public FuelTank(float currentAmount, float maxAmount)
        {
            MaxAmount = maxAmount;
            CurrentAmount = currentAmount;
        }

        public void Consume(float amount)
        {
            if(HasEnougToSupply(amount))
            {
                CurrentAmount -= amount;
            }
        }

        public bool HasEnougToSupply(float amount)
        {
            return CurrentAmount - amount >= 0;
        }

        public void Refill(float amount)
        {
            CurrentAmount += amount;

            if(IsOverfilled())
            {
                CurrentAmount = MaxAmount;
            }
        }

        private bool IsOverfilled()
        {
            return CurrentAmount > MaxAmount;
        }
    }
}
