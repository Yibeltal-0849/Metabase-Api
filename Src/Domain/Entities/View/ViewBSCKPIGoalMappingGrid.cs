namespace XOKA.Domain.Entities.view
{
    public class ViewBSCKPIGoalMappingGrid
	{
		public System.Guid KPIMapping_ID { get; set; }
		public string Innitiative_ID { get; set; }
		public System.Guid? ASPA_ID { get; set; }
		public System.Guid? Type_Of_Innitiative { get; set; }
		public string Innitiative { get; set; }
		public double? BaseLine { get; set; }
		public System.Guid? KPI_ID { get; set; }
		public string Performance_Indicator { get; set; }
		public double? Target { get; set; }
		public double? MIN { get; set; }
		public double? MAX { get; set; }
		public double? Value { get; set; }
		public double? Weight { get; set; }
		public double? Accomplished_Per { get; set; }
		public double? Varance { get; set; }
	}
}
