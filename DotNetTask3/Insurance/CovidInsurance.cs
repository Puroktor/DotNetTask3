using DotNetTask3.Entity;

namespace DotNetTask3.Insurance
{
    public class CovidInsurance : HealthInsurance
    {
        public const double COST = 200;
        public const double PAY_OUT_SUM = 1000;
        public const double RISK_FACTOR = 1;

        public CovidInsurance(Person insurant) : base(insurant, COST)
        {
        }

        public override double CalculateCompensation()
        {
            return PAY_OUT_SUM;
        }

        public override double CalculateRiskFactor()
        {
            return RISK_FACTOR;
        }
    }
}
