


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.PBlanketpurchaseorder.PBlanketpurchaseorderInsert.PBlanketpurchaseorderInsertCommand
{

    /// @author  Shimels Alem  [P_Blanket purchase orderInsert] stored procedure.


    public class PBlanketpurchaseorderInsertCommand : IRequest<IList<PBlanketPurchaseOrder_Purchase_Line>>
    {
        public System.Guid? Purchase_Line { get; set; }
        public int? Qty_to_Receive { get; set; }
        public int? Quantity_Received { get; set; }
        public int? Quantity_Invoiced { get; set; }
    }
		
		
		 
}
 
 