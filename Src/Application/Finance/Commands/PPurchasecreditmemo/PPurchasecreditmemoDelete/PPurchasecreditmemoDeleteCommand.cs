 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.PPurchasecreditmemo.PPurchasecreditmemoDelete.PPurchasecreditmemoDeleteCommand
{

    // @author  Shimels Alem  [P_Purchase credit memoDelete] stored procedure.


    public class PPurchasecreditmemoDeleteCommand : IRequest<IList<PPurchaseCreditMemo_Purchase_Line>>
    {
        public System.Guid Purchase_Line { get; set; }
    }
		
     
		
		 
}
 
 