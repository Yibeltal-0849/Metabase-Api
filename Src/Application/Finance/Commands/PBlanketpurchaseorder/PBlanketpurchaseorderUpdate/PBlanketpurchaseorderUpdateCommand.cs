using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.PBlanketpurchaseorder.PBlanketpurchaseorderUpdate.PBlanketpurchaseorderUpdateCommand
{

    /// @author  Shimels Alem  [P_Blanket purchase orderUpdate] stored procedure.


    public class PBlanketpurchaseorderUpdateCommand : IRequest<IList<PBlanketPurchaseOrder_Purchase_Line>>
   {
        public System.Guid Purchase_Line { get; set; }
        public int? Qty_to_Receive { get; set; }
        public int? Quantity_Received { get; set; }
        public int? Quantity_Invoiced { get; set; }
    }
		
		
		 
}

