 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cChartOfAccount.cChartOfAccountDelete.cChartOfAccountDeleteCommand
{

    // @author  Shimels Alem  c_Chart_Of_AccountDelete stored procedure.


    public class cChartOfAccountDeleteCommand : IRequest<IList<CChartOfAccount_Account_ID>>
    {
        public string Account_ID { get; set; }
    }
		
     
		
		 
	}
 
 