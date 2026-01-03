using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.PPurchaseorder.PPurchaseorderUpdate.PPurchaseorderUpdateCommand
{

	/// @author  Shimels Alem  [P_Purchase orderUpdate] stored procedure.


	public class PPurchaseorderUpdateCommand : IRequest<IList<PPurchaseOrder_Purchase_Line_ID>>
   {
        public System.Guid? Purchase_Line_ID { get; set; }
        public double? Direct_Unit_Cost_Excl_VAT { get; set; }
        public double? Qty_to_Receive { get; set; }
        public double? Quantity_Received { get; set; }
        public double? Qty_to_Invoice { get; set; }
        public double? Quantity_Invoiced { get; set; }
        public double? Qty_to_Assign { get; set; }
        public double? Qty_Assigned { get; set; }
        public System.DateTime? Planned_Receipt_Date { get; set; }
        public System.DateTime? Expected_Receipt_Date { get; set; }
        public System.DateTime? Order_Date { get; set; }
    }
		
		
		 
}

