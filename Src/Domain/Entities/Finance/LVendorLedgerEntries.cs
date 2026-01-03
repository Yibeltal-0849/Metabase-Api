namespace XOKA.Domain.Entities.Finance
{
    public class L_Vendor_Ledger_Entries
	{
		public System.Guid Branch_ID { get; set; }
		public System.DateTime Period { get; set; }
		public System.DateTime PostingDate { get; set; }
		public string DocumentType { get; set; }
		public string DocumentNo { get; set; }
		public string ExternalDocumentNo { get; set; }
		public string VendorNo { get; set; }
		public string Description { get; set; }
		public string CurrencyCode { get; set; }
		public System.Double? OriginalAmount  { get; set; }
		public System.Double? Amount { get; set; }
		public System.Double? RemainingAmount { get; set; }
		public System.DateTime? DueDate { get; set; }
		public System.DateTime? PmtDiscountDate { get; set; }
		public System.DateTime? PmtDiscToleranceDate { get; set; }
		public System.DateTime? OriginalPmtDiscPossible { get; set; }
		public System.DateTime? RemainingPmtDiscPossible { get; set; }
		public double MaxPaymentTolerance { get; set; }
		public bool? Open { get; set; }
		public bool? OnHold { get; set; }
		public System.Int64 EntryNo { get; set; }
	}
}
