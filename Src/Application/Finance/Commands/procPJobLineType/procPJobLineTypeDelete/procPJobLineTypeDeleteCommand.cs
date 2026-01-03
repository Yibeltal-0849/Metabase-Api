 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procPJobLineType.procPJobLineTypeDelete.procPJobLineTypeDeleteCommand
{

    // @author  Shimels Alem  proc_P_Job_Line_TypeDelete stored procedure.


    public class procPJobLineTypeDeleteCommand : IRequest<IList<PJobLineType_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 