using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.SBlanketSalesorder.SBlanketSalesorderUpdate.SBlanketSalesorderUpdateCommand
{

	/// @author  Shimels Alem  [S_Blanket_Sales_orderUpdate] stored procedure.


	public class SBlanketSalesorderUpdateCommand : IRequest<IList<SBlanketSalesOrder_Sales_Blanket_Order_Line>>
   {
        public string Sales_Blanket_Order_Line { get; set; }
        public int? Qty_to_Ship { get; set; }
        public int? Quantity_Shipped { get; set; }
        public int? Quantity_Invoiced { get; set; }
        public System.DateTime? Shipment_Date { get; set; }
    }
		
		
		 
}

