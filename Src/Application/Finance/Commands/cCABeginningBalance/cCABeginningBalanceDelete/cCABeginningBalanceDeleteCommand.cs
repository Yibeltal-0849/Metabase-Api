 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cCABeginningBalance.cCABeginningBalanceDelete.cCABeginningBalanceDeleteCommand
{

    // @author  Shimels Alem  c_CA_Beginning_BalanceDelete stored procedure.


    public class cCABeginningBalanceDeleteCommand : IRequest<IList<CCaBeginningBalance_Period>>
    {
        public System.DateTime Period { get; set; }
        public string Account_id { get; set; }
    }
		
     
		
	 
}
 
 