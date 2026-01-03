using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procPaySlip.GetprocPaySlipLoadAll;

namespace Application.HRA.Quiries.procPaySlip.GetprocPaySlipByPrimaryKey
{
    /// @author  Shimels Alem proc_Pay_SlipLoadByPrimaryKey stored procedure.

    public class GetprocPaySlipByPrimaryKey : IRequest<GetprocPaySlipLoadAllListVm>
    {
        public System.Guid Pay_Slip_ID { get; set; }
    }
}
