using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procJBankReconTransaction.GetprocJBankReconTransactionLoadAll;

namespace Application.Finance.Quiries.procJBankReconTransaction.GetprocJBankReconTransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_J_Bank_Recon_TransactionLoadByPrimaryKey stored procedure.

    public class GetprocJBankReconTransactionByPrimaryKey : IRequest<GetprocJBankReconTransactionLoadAllListVm>
    {
       public System.Guid Trans_ID { get; set; }
    }
}
