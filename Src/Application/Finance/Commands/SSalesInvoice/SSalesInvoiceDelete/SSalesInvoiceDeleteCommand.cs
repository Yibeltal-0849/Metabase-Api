 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SSalesInvoice.SSalesInvoiceDelete.SSalesInvoiceDeleteCommand
{

    // @author  Shimels Alem  S_Sales_InvoiceDelete stored procedure.


    public class SSalesInvoiceDeleteCommand : IRequest<IList<SSalesInvoice_Sales_Invoice_Line>>
    {
        public string Sales_Invoice_Line { get; set; }
    }
		
     
		
		 
}
 
 