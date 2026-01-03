


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SSalseorder.SSalseorderInsert.SSalseorderInsertCommand
{

    /// @author  Shimels Alem  S_Salse_orderInsert stored procedure.


    public class SSalseorderInsertCommand : IRequest<IList<SSalseOrder_Sales_Order_Line_ID>>
    {
        public string Sales_Order_Line_ID { get; set; }
        public int Reserved_Quantity { get; set; }
        public int? Qty_to_Ship { get; set; }
        public int? Quantity_Shipped { get; set; }
        public int? Qty_to_Invoice { get; set; }
        public int? Quantity_Invoiced { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
        public System.DateTime? Planned_Delivery_Date { get; set; }
        public System.DateTime? Planned_Shipment_Date { get; set; }
        public System.DateTime? Shipment_Date { get; set; }
    }
		
		
		 
}
 
 