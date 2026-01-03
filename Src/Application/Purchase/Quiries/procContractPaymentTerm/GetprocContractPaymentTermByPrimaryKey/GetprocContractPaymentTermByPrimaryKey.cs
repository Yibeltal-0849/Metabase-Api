using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Purchase.Quiries.procContractPaymentTerm.GetprocContractPaymentTermLoadAll;

namespace Application.Purchase.Quiries.procContractPaymentTerm.GetprocContractPaymentTermByPrimaryKey
{
    /// @author  Shimels Alem proc_Contract_PaymentTermLoadByPrimaryKey stored procedure.

    public class GetprocContractPaymentTermByPrimaryKey : IRequest<GetprocContractPaymentTermLoadAllListVm>
    {
        public System.Guid Payment_TermID { get; set; }
    }
}
