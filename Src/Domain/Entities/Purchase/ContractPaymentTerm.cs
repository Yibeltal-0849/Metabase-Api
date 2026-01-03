
namespace XOKA.Domain.Entities.Purchase
{
    public class ContractPaymentTerm
	{
		public System.Guid Payment_TermID { get; set; }
		public string Payment_Term { get; set; }
		public string Declaration { get; set; }
		public bool? Is_Approved { get; set; }
		public string ContractID { get; set; }
		public double? Percent { get; set; }
        public double? Total_Percent { get; set; }
        public string? Parent { get; set; }
        public string? description { get; set; }


    }
}
