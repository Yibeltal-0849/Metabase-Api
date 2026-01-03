using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Finance.Quiries.procPayment.GetprocPaymentLoadAll
{
    /// @author  Shimels Alem  proc_PaymentLoadAll stored procedure.

    public class GetprocPaymentLoadAllListVm
    {
        public IList<GetprocPaymentLoadAllVm> procPayments { get; set; }
    }
}
