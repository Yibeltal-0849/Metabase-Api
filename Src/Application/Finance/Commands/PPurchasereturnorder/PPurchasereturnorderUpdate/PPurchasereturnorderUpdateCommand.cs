using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.PPurchasereturnorder.PPurchasereturnorderUpdate.PPurchasereturnorderUpdateCommand
{

	/// @author  Shimels Alem  [P_Purchase return orderUpdate] stored procedure.


	public class PPurchasereturnorderUpdateCommand : IRequest<IList<PPurchaseReturnOrder_Purchase_Line>>
   {
        public System.Guid Purchase_Line { get; set; }
        public System.Guid? Return_Reason_Code { get; set; }
        public int? Return_Qty_to_Ship { get; set; }
        public int? Return_Qty_Shipped { get; set; }
        public int? Qty_to_Invoice { get; set; }
        public int? Quantity_Invoiced { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
    }
		
		
		 
}

