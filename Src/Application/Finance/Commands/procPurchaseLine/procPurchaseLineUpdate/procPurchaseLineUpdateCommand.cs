using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procPurchaseLine.procPurchaseLineUpdate.procPurchaseLineUpdateCommand
{

	/// @author  Shimels Alem  proc_Purchase_LineUpdate stored procedure.


	public class procPurchaseLineUpdateCommand : IRequest<IList<PurchaseLine_PurchaseLineID>>
   {
		public System.Guid Purchase_Line_ID { get; set; }
		public string Trans_NO { get; set; }
		public string Type { get; set; }
		public string No { get; set; }
		public string Description { get; set; }
		public string Location_Code { get; set; }
		public long? Quantity { get; set; }
		public string Unit { get; set; }
		public System.Double? Unit_Price_Excl_VAT { get; set; }
		public System.Double? Line_Amount_Excl_VAT { get; set; }
		public System.Double? Line_Discount_Per { get; set; }
	}
		
		
		 
}

