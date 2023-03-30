using DotNetTask3.Entity;

namespace DotNetTask3.Insurance
{
    public class HealthInsurance : PersonalInsurance
    {
        public const int BASE_COST = 500;
        public const int PAY_OUT_COST_QUANTITY = 3;
        public const double MAX_RISK_FACTOR = 5;

        protected HealthInsurance(Person insurant, double cost) : base(insurant, cost)
        {
        }

        public HealthInsurance(Person insurant) : base(insurant, BASE_COST)
        {
        }


        public override double CalculateCompensation()
        {
            return GetCost() * PAY_OUT_COST_QUANTITY;
        }

        public override double CalculateRiskFactor()
        {
            return MAX_RISK_FACTOR * (0.5 + 0.5 * Person.MAX_AGE / Insurant.Age);
        }
    }
}
