
using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;
namespace Application.Purchase.Commands.procReciveRent.procContractReciveRentInsert.procReciveRentInsertCommand
{
    public class procReciveRentInsertCommand : IRequest<IList<ReciveRentRent_Collection_ID>>
    {
		public System.Guid Rent_Collection_ID { get; set; }
		public string Rent_Contract_ID { get; set; }
		public string Month { get; set; }
		public string Payment_Method { get; set; }
		public string Currency { get; set; }
		public string Unit { get; set; }
		public string QTY { get; set; }
		public string Unit_Price { get; set; }
		public string Total_Price { get; set; }
		public string Remark { get; set; }
		public string Bank_Convermation { get; set; }
		public bool? Discount { get; set; }
		public System.Guid Updated_By { get; set; }
	}
}
