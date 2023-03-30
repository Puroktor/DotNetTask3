using DotNetTask3.Entity;

namespace DotNetTask3.Insurance
{
    public abstract class PropertyInsurance : BaseInsurance
    {
        protected PropertyInsurance(Property property, double cost) : base(cost)
        {
            Property = property;
        }

        public Property Property { get; private set; }
    }
}
