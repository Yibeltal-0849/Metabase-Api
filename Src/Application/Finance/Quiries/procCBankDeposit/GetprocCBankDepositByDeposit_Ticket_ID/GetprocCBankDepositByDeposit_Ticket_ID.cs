using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procCBankDeposit.GetprocCBankDepositLoadAll;

namespace Application.Finance.Quiries.procCBankDeposit.GetprocCBankDepositByDeposit_Ticket_ID
{
    /// @author  Shimels Alem proc_C_Bank_DepositLoadByPrimaryKey stored procedure.

    public class GetprocCBankDepositByDeposit_Ticket_ID : IRequest<GetprocBankReconciliationLoadAllListVm>
    {
        public string Deposit_Ticket_ID { get; set; }
    }
}
