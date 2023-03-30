using DotNetTask3.Entity;

namespace DotNetTask3.Insurance
{
    public class CarInsurance : PropertyInsurance
    {
        public const double COST_FACTOR = 0.1;
        public const double MAX_RISK_FACTOR = 5;
        public const int THRESHOLD_DRIVING_EXPERIENCE = 10;

        public CarInsurance(Property car, Person driver) : base(car, COST_FACTOR * car.Price)
        {
            Driver = driver;
        }

        public Person Driver { get; private set; }

        public override double CalculateCompensation()
        {
            return Property.DamageFactor * Property.Price;
        }

        public override double CalculateRiskFactor()
        {
            return MAX_RISK_FACTOR *
                (0.8 * Math.Min(1, THRESHOLD_DRIVING_EXPERIENCE / Driver.DrivingExperience) +
                    Driver.Income * 12 < Property.Price ? 0.2 : 0);
        }
    }
}
