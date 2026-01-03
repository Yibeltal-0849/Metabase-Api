using AutoMapper;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.SSalesInvoice.SSalesInvoiceUpdate.SSalesInvoiceUpdateCommand
{

	/// @author  Shimels Alem  S_Sales_InvoiceUpdate stored procedure.


	public class SSalesInvoiceUpdateCommand : IRequest<IList<SSalesInvoice_Sales_Invoice_Line>>
   {
		public string Sales_Invoice_Line { get; set; }
		public int? Qty_to_Assign { get; set; }
		public int? Qty_Assigned { get; set; }
	}
		
		
		 
}

