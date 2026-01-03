 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.GenPostingType.GenPostingTypeDelete.GenPostingTypeDeleteCommand
{

    // @author  Shimels Alem  Gen_Posting_TypeDelete stored procedure.


    public class GenPostingTypeDeleteCommand : IRequest<IList<GenPostingType_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 