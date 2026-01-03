


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procBankAccountPostingGroup.procBankAccountPostingGroupInsert.procBankAccountPostingGroupInsertCommand
{

    /// @author  Shimels Alem  proc_Bank_Account_Posting_GroupInsert stored procedure.


    public class procBankAccountPostingGroupInsertCommand : IRequest<IList<BankAccountPostingGroup_Code>>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Account_ID { get; set; }
        public string Orgid { get; set; }
        public System.Guid? Branch { get; set; }
        public bool? dufault { get; set; }
    }
		
		
		 
}
 
 