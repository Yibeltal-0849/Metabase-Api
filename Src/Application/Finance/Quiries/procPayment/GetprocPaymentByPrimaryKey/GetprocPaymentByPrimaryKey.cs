using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPayment.GetprocPaymentLoadAll;

namespace Application.Finance.Quiries.procPayment.GetprocPaymentByPrimaryKey
{
    /// @author  Shimels Alem proc_PaymentLoadByPrimaryKey stored procedure.

    public class GetprocPaymentByPrimaryKey : IRequest<GetprocPaymentLoadAllListVm>
    {
        public System.Guid PID { get; set; }
    }
}
