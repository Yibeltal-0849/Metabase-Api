
namespace XOKA.Domain.Entities.Bsc
{
    public class KPIGoalMapping
	{
		public System.Guid KPIMapping_ID { get; set; }
		public System.Guid? KPI_ID { get; set; }
		public string Innitiative_ID { get; set; }
		public System.Double? BaseLine { get; set; }
		public System.Double? Target { get; set; }
		public System.Double? MIN { get; set; }
		public System.Double? MAX { get; set; }
		public System.Double? Value { get; set; }
		public System.Double? Weight { get; set; }
		public System.Double? Accomplished_Per { get; set; }
		public System.Double? Varance { get; set; }

	}
}
