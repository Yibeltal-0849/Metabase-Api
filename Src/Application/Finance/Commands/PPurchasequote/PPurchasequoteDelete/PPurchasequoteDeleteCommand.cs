 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.PPurchasequote.PPurchasequoteDelete.PPurchasequoteDeleteCommand
{

    // @author  Shimels Alem  [P_Purchase quoteDelete] stored procedure.


    public class PPurchasequoteDeleteCommand : IRequest<IList<PPurchaseQuote_Purchase_Line>>
    {
        public System.Guid Purchase_Line { get; set; }
    }
		
     
		
		 
}
 
 