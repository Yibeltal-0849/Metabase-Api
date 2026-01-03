 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.PPurchaseorder.PPurchaseorderDelete.PPurchaseorderDeleteCommand
{

    // @author  Shimels Alem  [P_Purchase orderDelete] stored procedure.


    public class PPurchaseorderDeleteCommand : IRequest<IList<PPurchaseOrder_Purchase_Line_ID>>
    {
        public System.Guid Purchase_Line_ID { get; set; }
    }
		
     
		
		 
}
 
 