 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.PPurchasereturnorder.PPurchasereturnorderDelete.PPurchasereturnorderDeleteCommand
{

    // @author  Shimels Alem  [P_Purchase return orderDelete] stored procedure.


    public class PPurchasereturnorderDeleteCommand : IRequest<IList<PPurchaseReturnOrder_Purchase_Line>>
    {
        public System.Guid Purchase_Line { get; set; }
    }
		
     
		
		 
}
 
 