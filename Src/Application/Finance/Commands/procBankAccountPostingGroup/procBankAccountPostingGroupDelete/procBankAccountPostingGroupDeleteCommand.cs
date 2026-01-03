 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procBankAccountPostingGroup.procBankAccountPostingGroupDelete.procBankAccountPostingGroupDeleteCommand
{

    // @author  Shimels Alem  proc_Bank_Account_Posting_GroupDelete stored procedure.


    public class procBankAccountPostingGroupDeleteCommand : IRequest<IList<BankAccountPostingGroup_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 