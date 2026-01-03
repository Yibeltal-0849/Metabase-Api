using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procPaySlip.GetprocPaySlipLoadAll;

namespace Application.Finance.Quiries.procPaySlip.GetprocPaySlipByPrimaryKey
{
    /// @author  Shimels Alem proc_Pay_SlipLoadByPrimaryKey stored procedure.

    public class GetprocPaySlipByPrimaryKey : IRequest<GetprocPaySlipLoadAllListVm>
    {
        public System.Guid Pay_Slip_ID { get; set; }
    }
}
