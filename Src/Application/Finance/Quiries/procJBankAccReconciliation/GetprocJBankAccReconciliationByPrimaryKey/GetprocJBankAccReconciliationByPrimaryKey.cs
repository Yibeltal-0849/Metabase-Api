using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procJBankAccReconciliation.GetprocJBankAccReconciliationLoadAll;

namespace Application.Finance.Quiries.procJBankAccReconciliation.GetprocJBankAccReconciliationByPrimaryKey
{
    /// @author  Shimels Alem proc_J_Bank_Acc_ReconciliationLoadByPrimaryKey stored procedure.

    public class GetprocJBankAccReconciliationByPrimaryKey : IRequest<GetprocJBankAccReconciliationLoadAllListVm>
    {
        public System.Guid Branch_ID { get; set; }
        public System.Guid Trans_ID { get; set; }
        public System.DateTime Transaction_Date { get; set; }
    }
}
