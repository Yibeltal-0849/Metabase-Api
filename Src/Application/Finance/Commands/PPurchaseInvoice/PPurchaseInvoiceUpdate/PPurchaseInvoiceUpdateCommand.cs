using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.PPurchaseInvoice.PPurchaseInvoiceUpdate.PPurchaseInvoiceUpdateCommand
{

	/// @author  Shimels Alem  [P_Purchase_InvoiceUpdate] stored procedure.


	public class PPurchaseInvoiceUpdateCommand : IRequest<IList<P_Purchase_Invoice_Purchase_Line>>
   {
        public System.Guid Purchase_Line { get; set; }
        public string Direct_Unit_Cost_Excl_VAT { get; set; }
        public double? Line_Discount_Per { get; set; }
        public System.Int32? Qty_to_Assign { get; set; }
        public System.Int32? Qty_Num_Assigned { get; set; }
    }
		
		
		 
}

