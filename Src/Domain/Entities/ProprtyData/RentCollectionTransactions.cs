
namespace XOKA.Domain.Entities.ProprtyData
{
    public class RentCollectionTransactions
	{
        public System.Guid Rent_Collection_ID { get; set; }
        public System.DateTime? Period { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_date { get; set; }
        public bool? Generate { get; set; }
        public string Archived_Pay_Slip { get; set; }

    }
}
