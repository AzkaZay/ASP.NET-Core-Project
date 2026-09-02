namespace PatisserieCD.Models
{
    public class Product
    {
        public int Id {  get; set; }
        public string Reference { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description {  get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public decimal? B2BPrice { get; set; }
        public bool Available { get; set; }
        public int PreparationLeadTimeHours { get; set; }
        public int? MinimumAlertStock {  get; set; }
    }
}
