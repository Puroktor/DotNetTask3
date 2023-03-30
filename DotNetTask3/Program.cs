using DotNetTask3.Entity;
using DotNetTask3.Insurance;

namespace DotNetTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person oldPerson = new(60, 3000, 5);
            Person youngPerson = new(20, 1000, 3);
            Person someone = new(36, 2400, 1);

            Property car = new(6000, 0);

            Derivative derivative= new();

            LifeInsurance oldPersonLifeIns = new(oldPerson);
            derivative.AddInsurance(oldPersonLifeIns);

            LifeInsurance somePersonLifeIns = new(someone);
            derivative.AddInsurance(somePersonLifeIns);

            HealthInsurance youngPersonHealthIns = new(youngPerson);
            derivative.AddInsurance(youngPersonHealthIns);

            CovidInsurance oldPersonCovidIns = new(oldPerson);
            derivative.AddInsurance(oldPersonCovidIns);

            CovidInsurance somePersonCovidIns = new(someone);
            derivative.AddInsurance(somePersonCovidIns);

            CarInsurance carInsurance = new(car, oldPerson);
            derivative.AddInsurance(carInsurance);

            Console.WriteLine(derivative.GetTotalCost());
            derivative.SortInsurancesByRisk();

            InsuranceSearchRequest searchRequest = new()
            {
                RiskFactorLower = 0.5,
                CostUpper = 500
            };
            derivative.FindInsurances(searchRequest);
        }
    }
}