namespace XOKA.Domain.Entities.HRA
{
    public class CourtOrderDeduction
    {
         public System.Guid Court_Order_ID { get; set; }
         public string Employee_ID { get; set; }
	     public string Sub_Account_No { get; set; }
	     public string Payee_Name { get; set; }
	     public double? Amount { get; set; }
	     public byte[] Court_Letter { get; set; }
    }
}
