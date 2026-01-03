 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.Finance.Commands.cAccountCat.cAccountCatDelete.cAccountCatDeleteCommand
{

    // @author  Shimels Alem  c_Account_CatDelete stored procedure.


    public class cAccountCatDeleteCommand : IRequest<IList<Proc_C_Account_Cat_Code>>
    {
        public int Code { get; set; }
    }
		
     
		
		 
	}
 
 