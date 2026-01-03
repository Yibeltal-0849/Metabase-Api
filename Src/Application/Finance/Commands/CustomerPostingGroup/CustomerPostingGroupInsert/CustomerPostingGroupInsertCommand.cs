


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CustomerPostingGroup.CustomerPostingGroupInsert.CustomerPostingGroupInsertCommand
{

    /// @author  Shimels Alem  Customer_Posting_GroupInsert stored procedure.


    public class CustomerPostingGroupInsertCommand : IRequest<IList<CustomerPostingGroup_Code>>
    {
        public string Code { get; set; }
        public string Receivable_Account { get; set; }
        public string Service_Charge_Account { get; set; }
        public string Payment_Disc_Debit_Account { get; set; }
        public string Payment_Disc_Credit_Account { get; set; }
        public string Addtional_Fee_Account { get; set; }
        public string Interest_Account { get; set; }
        public bool? IsActive { get; set; }
    }
		
		
		 
}
 
 