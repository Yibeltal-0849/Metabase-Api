


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SBlanketSalesorder.SBlanketSalesorderInsert.SBlanketSalesorderInsertCommand
{

    /// @author  Shimels Alem  [S_Blanket_Sales_orderInsert] stored procedure.


    public class SBlanketSalesorderInsertCommand : IRequest<IList<SBlanketSalesOrder_Sales_Blanket_Order_Line>>
    {
        public string Sales_Blanket_Order_Line { get; set; }
        public int? Qty_to_Ship { get; set; }
        public int? Quantity_Shipped { get; set; }
        public int? Quantity_Invoiced { get; set; }
        public System.DateTime? Shipment_Date { get; set; }
    }
		
		
		 
}
 
 