using DotNetTask3.Entity;

namespace DotNetTask3.Insurance
{
    public class LifeInsurance : PersonalInsurance
    {
        public const int BASE_COST = 1000;
        public const int PAY_OUT_COST_QUANTITY = 6;
        public const double MAX_RISK_FACTOR = 10;

        public LifeInsurance(Person insurant) : base(insurant, BASE_COST)
        {
        }

        public override double CalculateCompensation()
        {
            return GetCost() * PAY_OUT_COST_QUANTITY;
        }

        public override double CalculateRiskFactor()
        {
            return MAX_RISK_FACTOR * Person.MAX_AGE / Insurant.Age;
        }
    }
}
