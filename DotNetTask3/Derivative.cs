using DotNetTask3.Insurance;
using System.Text;

namespace DotNetTask3
{
    public class Derivative
    {
        private readonly List<BaseInsurance> insurances = new();

        private class InsuranceByRiskDescComparer : IComparer<BaseInsurance>
        {
            public int Compare(BaseInsurance? ins1, BaseInsurance? ins2)
            {
                if (ins1 is null || ins2 is null)
                    throw new ArgumentException("Can't sort nullable insurances");
                double riskFactor1 = ins1.CalculateRiskFactor();
                double riskFactor2 = ins2.CalculateRiskFactor();
                return riskFactor2.CompareTo(riskFactor1);
            }
        }

        public void AddInsurance(BaseInsurance insurance)
        {
            insurances.Add(insurance);
        }

        public void RemoveInsurance(BaseInsurance insurance)
        {
            insurances.Remove(insurance);
        }

        public double GetTotalCost()
        {
            return insurances.Select(ins => ins.GetCost()).Sum();
        }

        public void SortInsurancesByRisk()
        {
            var comparer = new InsuranceByRiskDescComparer();
            insurances.Sort(comparer);

            //for (var i = 1; i < insurances.Count; i++)
            //{
            //    var key = insurances[i];
            //    var j = i;
            //    while ((j > 1) && comparer.Compare(insurances[j - 1], key) > 0)
            //    {
            //        (insurances[j - 1], insurances[j]) = (insurances[j], insurances[j - 1]);
            //        j--;
            //    }
            //    insurances[j] = key;
            //}
        }

        public List<BaseInsurance> FindInsurances(InsuranceSearchRequest request)
        {
            IEnumerable<BaseInsurance> enumerable = insurances;
            if (request.CostLower is not null)
            {
                enumerable = enumerable.Where(ins => ins.GetCost() >= request.CostLower);
            }
            if (request.CostUpper is not null)
            {
                enumerable = enumerable.Where(ins => ins.GetCost() <= request.CostUpper);
            }
            if (request.RiskFactorLower is not null)
            {
                enumerable = enumerable.Where(ins => ins.CalculateRiskFactor() >= request.RiskFactorLower);
            }
            if (request.RiskFactorUpper is not null)
            {
                enumerable = enumerable.Where(ins => ins.CalculateRiskFactor() > request.RiskFactorUpper);
            }
            if (request.CompensationLower is not null)
            {
                enumerable = enumerable.Where(ins => ins.CalculateCompensation() >= request.CostLower);
            }
            if (request.CompensationUpper is not null)
            {
                enumerable = enumerable.Where(ins => ins.CalculateCompensation() <= request.CompensationUpper);
            }
            return enumerable.ToList();
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new();
            stringBuilder.AppendLine(base.ToString());
            foreach (BaseInsurance insurance in insurances) 
            {
                stringBuilder.AppendLine(insurance.ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
