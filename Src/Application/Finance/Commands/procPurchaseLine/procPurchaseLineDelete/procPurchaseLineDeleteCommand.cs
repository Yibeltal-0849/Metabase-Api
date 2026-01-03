 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procPurchaseLine.procPurchaseLineDelete.procPurchaseLineDeleteCommand
{

    // @author  Shimels Alem  proc_Purchase_LineDelete stored procedure.


    public class procPurchaseLineDeleteCommand : IRequest<IList<PurchaseLine_PurchaseLineID>>
    {
        public System.Guid Purchase_Line_ID { get; set; }
    }
		
     
		
		 
}
 
 