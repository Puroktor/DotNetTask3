namespace DotNetTask3
{
    public class InsuranceSearchRequest
    {
        public double? CostLower { get; set; }
        public double? CostUpper { get; set; }
        public double? CompensationLower { get; set; }
        public double? CompensationUpper { get; set; }
        public double? RiskFactorLower { get; set; }
        public double? RiskFactorUpper { get; set; }
    }
}
