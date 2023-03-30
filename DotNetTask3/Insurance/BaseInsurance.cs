namespace DotNetTask3.Insurance
{
    public abstract class BaseInsurance
    {
        public BaseInsurance(double baseCost)
        {
            BaseCost = baseCost;
        }

        public double BaseCost { get; private set; }

        public double GetCost()
        {
            return BaseCost * CalculateRiskFactor();
        }
        public abstract double CalculateCompensation();
        public abstract double CalculateRiskFactor();
    }
}
