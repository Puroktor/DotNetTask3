using System.Text;

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

        public override string ToString()
        {
            StringBuilder stringBuilder = new();

            stringBuilder.Append(base.ToString());
            stringBuilder.Append(" {Cost: ");
            stringBuilder.Append(Math.Round(GetCost(), 2));
            stringBuilder.Append("; Compensation:");
            stringBuilder.Append(Math.Round(CalculateCompensation(), 2));
            stringBuilder.Append("; Risk:");
            stringBuilder.Append(Math.Round(CalculateRiskFactor(), 2));
            stringBuilder.Append("}");

            return stringBuilder.ToString();
        }
    }
}
