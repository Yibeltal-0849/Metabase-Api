namespace XOKA.Domain.Entities.Finance
{
    public class JBankReconTransaction
    {
        public System.Guid Trans_ID { get; set; }
        public System.DateTime? Statement_Date { get; set; }
	    public string Statement_No { get; set; }
	    public decimal Balance_Last_Statement { get; set; }
        public decimal Statement_Ending_Balance { get; set; }
    }
}
