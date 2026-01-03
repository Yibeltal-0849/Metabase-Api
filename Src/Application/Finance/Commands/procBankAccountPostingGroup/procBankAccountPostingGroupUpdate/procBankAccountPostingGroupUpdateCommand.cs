using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procBankAccountPostingGroup.procBankAccountPostingGroupUpdate.procBankAccountPostingGroupUpdateCommand
{

    /// @author  Shimels Alem  proc_Bank_Account_Posting_GroupUpdate stored procedure.


    public class procBankAccountPostingGroupUpdateCommand : IRequest<IList<BankAccountPostingGroup_Code>>
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

