using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CustomerPostingGroup.CustomerPostingGroupUpdate.CustomerPostingGroupUpdateCommand
{

	/// @author  Shimels Alem  Customer_Posting_GroupUpdate stored procedure.


	public class CustomerPostingGroupUpdateCommand : IRequest<IList<CustomerPostingGroup_Code>>
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

