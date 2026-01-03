


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SSalesReturnOrder.SSalesReturnOrderInsert.SSalesReturnOrderInsertCommand
{

    /// @author  Shimels Alem  S_Sales_Return_OrderInsert stored procedure.


    public class SSalesReturnOrderInsertCommand : IRequest<IList<SSalesReturnOrder_Sales_Return_Order_Line>>
    {
        public string Sales_Return_Order_Line { get; set; }
        public System.Guid? Return_Reason_Code { get; set; }
        public int? Return_Qty_to_Receive { get; set; }
        public int? Return_Qty_Received { get; set; }
        public int? Qty_to_Invoice { get; set; }
        public int? Quantity_Invoiced { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
    }
		
		
		 
}
 
 