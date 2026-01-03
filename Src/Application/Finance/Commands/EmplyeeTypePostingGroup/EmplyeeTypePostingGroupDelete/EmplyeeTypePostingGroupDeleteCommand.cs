 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.EmplyeeTypePostingGroup.EmplyeeTypePostingGroupDelete.EmplyeeTypePostingGroupDeleteCommand
{

    // @author  Shimels Alem  c_Account_CatDelete stored procedure.


    public class EmplyeeTypePostingGroupDeleteCommand : IRequest<IList<Emplyee_Type_Posting_GroupID>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
	}
 
 