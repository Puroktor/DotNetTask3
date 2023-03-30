using DotNetTask3.Entity;

namespace DotNetTask3.Insurance
{
    public class CarInsurance : PropertyInsurance
    {
        public const double COST_FACTOR = 0.1;
        public const double MAX_RISK_FACTOR = 20;
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
            double incomeFactor = Driver.Income * 12 < Property.Price ? 0.2 : 0;
            double experienceFactor = 0.8 * Math.Min(1, Driver.DrivingExperience * 1.0 / THRESHOLD_DRIVING_EXPERIENCE);
            return MAX_RISK_FACTOR * (incomeFactor + experienceFactor);
        }
    }
}
