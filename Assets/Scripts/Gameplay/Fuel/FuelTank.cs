namespace Assets.Scripts.Gameplay.Fuel
{
    public class FuelTank
    {
        public float MaxAmount { get; set; }
        public float CurrentAmount { get; set; }

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
    }
}
