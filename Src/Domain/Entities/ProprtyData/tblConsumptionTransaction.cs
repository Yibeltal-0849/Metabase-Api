
using System;

namespace XOKA.Domain.Entities.ProprtyData
{
    public class tblConsumptionTransaction
	{
		public string Tranaction_Id { get; set; }
		public DateTime? Start_Date { get; set; }
		public DateTime? End_Date { get; set; }
		public bool? Complited { get; set; }

	}
}
