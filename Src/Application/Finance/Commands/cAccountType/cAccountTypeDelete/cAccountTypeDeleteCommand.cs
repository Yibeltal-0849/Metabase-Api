 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cAccountType.cAccountTypeDelete.cAccountTypeDeleteCommand
{

    // @author  Shimels Alem  c_Account_TypeDelete stored procedure.


    public class cAccountTypeDeleteCommand : IRequest<IList<CAccountType_Id>>
    {
        public long Id { get; set; }
    }
		
     
		
		 
	}
 
 