using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.WHTPostingSetup.WHTPostingSetupUpdate.WHTPostingSetupUpdateCommand
{

	/// @author  Shimels Alem  WHT_Posting_SetupUpdate stored procedure.


	public class WHTPostingSetupUpdateCommand : IRequest<IList<WHT_Posting_Setup_With_Posting_Group>>
   {
		public string With_Posting_Group { get; set; }
		public string Bus_Posting_Group { get; set; }
		public string Prod_Posting_Group { get; set; }
		public string Prepaid_WHT_Acc_Code { get; set; }
		public string Payable_WHT_Acc_Code { get; set; }
		public string Bal_Prepaid_Account_Type { get; set; }
		public string Bal_Prepaid_Acc_Code { get; set; }
		public string Bal_Payable_Account_Type { get; set; }
		public string Bal_Payable_Acc_Code { get; set; }
		public string Purch_WHT_Adj_Acc_Code { get; set; }
		public string Sales_WHT_Adj_Acc_Code { get; set; }
	}
		
		
		 
}

