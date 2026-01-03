using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procCBankDeposit.GetprocCBankDepositLoadAll;

namespace Application.Finance.Quiries.procCBankDeposit.GetprocCBankDepositByPrimaryKey
{
    /// @author  Shimels Alem proc_C_Bank_DepositLoadByPrimaryKey stored procedure.

    public class GetprocCBankDepositByPrimaryKey : IRequest<GetprocBankReconciliationLoadAllListVm>
    {
        public System.Guid Id { get; set; }
    }
}
