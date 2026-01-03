


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SSalesInvoice.SSalesInvoiceInsert.SSalesInvoiceInsertCommand
{

    /// @author  Shimels Alem  S_Sales_InvoiceInsert stored procedure.


    public class SSalesInvoiceInsertCommand : IRequest<IList<SSalesInvoice_Sales_Invoice_Line>>
    {
        public string Sales_Invoice_Line { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
    }
		
		
		 
}
 
 