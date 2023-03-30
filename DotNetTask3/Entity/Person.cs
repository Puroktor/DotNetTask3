namespace DotNetTask3.Entity
{
    public class Person
    {
        public const int MAX_AGE = 80;

        private int age;

        public Person(int age, double income, int drivingExperience)
        {
            Age = age;
            Income = income;
            DrivingExperience = drivingExperience;
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > MAX_AGE)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Person age must be beetween 0 and {0}, got: {1}", MAX_AGE, value));
                }
                age = value;
            }
        }

        public double Income { get; set; }
        public int DrivingExperience { get; set; }
    }
}
