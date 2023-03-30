using DotNetTask3.Entity;

namespace DotNetTask3.Insurance
{
    public abstract class PersonalInsurance : BaseInsurance
    {
        public PersonalInsurance(Person insurant, double cost) : base(cost)
        {
            Insurant = insurant;
        }

        public Person Insurant { get; private set; }
    }
}
