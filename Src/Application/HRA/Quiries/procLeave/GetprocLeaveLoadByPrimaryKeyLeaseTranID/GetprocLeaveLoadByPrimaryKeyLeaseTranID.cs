using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procLeave.GetprocLeaveLoadAll;

namespace Application.HRA.Quiries.procLeave.GetprocLeaveLoadByPrimaryKeyLeaseTranID
{
    /// @author  Shimels Alem proc_LeaveLoadByPrimaryKey_Lease_Tran_ID stored procedure.

    public class GetprocLeaveLoadByPrimaryKeyLeaseTranID : IRequest<GetprocLeaveLoadAllListVm>
    {
        public Guid Lease_Tran_ID { get; set; }
    }
}
