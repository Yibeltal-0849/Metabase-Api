


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.BankReconciliation.BankReconciliationInsert.BankReconciliationInsertCommand
{

    /// @author  Shimels Alem  C_Bank_DepositInsert stored procedure.


    public class BankReconciliationInsertCommand : IRequest<IList<BankReconciliation_Id>>
    {
        public string Orderid { get; set; }
        public System.DateTime? trans_initate_time { get; set; }
        public string top_short_code { get; set; }
        public string short_code { get; set; }
        public string biz_org_name { get; set; }
        public string trans_status { get; set; }
        public string debit_party_mnemonic { get; set; }
        public string credit_party_mnemonic { get; set; }
        public double? Amount { get; set; }
        public string BillReferenceNumber { get; set; }
        public string bank_name { get; set; }

    }
		
		
		 
}
 
 