 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.J_Payroll_Journal.J_Payroll_JournalDelete.J_Payroll_JournalDeleteCommand
{

    // @author  Shimels Alem  c_CA_Beginning_BalanceDelete stored procedure.


    public class J_Payroll_JournalDeleteCommand : IRequest<IList<J_Payroll_Journal_Trans_ID>>
    {
        public System.Guid Trans_ID { get; set; }
        public System.DateTime Posting_Date { get; set;}
        public string Emplyee_ID { get; set; }
    }
		
     
		
	 
}
 
 