namespace DotNetTask3.Entity
{
    public class Property
    {
        public const double MAX_DAMAGE_FACTOR = 1.0;

        public Property(double price, double damageFactor)
        {
            Price = price;
            DamageFactor = damageFactor;
        }

        public double Price { get; set; }

        private double damageFactor;

        public double DamageFactor
        {
            get { return damageFactor; }
            set
            {
                if (value < 0 || value > MAX_DAMAGE_FACTOR)
                {
                    string errorMessage = string.Format("Property damage factor must be beetween 0 and {0}, got: {1}", MAX_DAMAGE_FACTOR, value);
                    throw new ArgumentOutOfRangeException(errorMessage);
                }
                damageFactor = value;
            }
        }
    }
}
