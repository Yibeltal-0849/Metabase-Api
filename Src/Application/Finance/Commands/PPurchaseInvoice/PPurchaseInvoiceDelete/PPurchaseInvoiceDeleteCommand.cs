 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.PPurchaseInvoice.PPurchaseInvoiceDelete.PPurchaseInvoiceDeleteCommand
{

    // @author  Shimels Alem  [P_Purchase_InvoiceDelete] stored procedure.


    public class PPurchaseInvoiceDeleteCommand : IRequest<IList<P_Purchase_Invoice_Purchase_Line>>
    {
        public System.Guid Purchase_Line { get; set; }
    }
		
     
		
		 
}
 
 