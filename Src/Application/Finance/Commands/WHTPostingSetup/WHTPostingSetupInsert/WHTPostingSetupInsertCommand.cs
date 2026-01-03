


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.WHTPostingSetup.WHTPostingSetupInsert.WHTPostingSetupInsertCommand
{

    /// @author  Shimels Alem  WHT_Posting_SetupInsert stored procedure.


    public class WHTPostingSetupInsertCommand : IRequest<IList<WHT_Posting_Setup_With_Posting_Group>>
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
 
 