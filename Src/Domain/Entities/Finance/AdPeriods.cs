namespace XOKA.Domain.Entities.Finance
{
    public class AdPeriods
    {
        public System.DateTime StartDate { get; set; }
        public System.DateTime? EndDate { get; set; }
        public string Org_Id { get; set; }
        public string Name { get; set; }
        public bool? Date_Locked { get; set; }
        public bool? New_Fiscal_Year { get; set; }
        public bool? Closed { get; set; }
        public string Year { get; set; }
        public bool? Inventory_Period_Closed { get; set; }
    }
}
