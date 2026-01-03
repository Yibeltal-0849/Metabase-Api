using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Vehicle.Quiries.procFleetSchdule.GetprocFleetSchduleLoadAll;

namespace Application.Vehicle.Quiries.procFleetSchdule.GetprocFleetSchduleByPrimaryKey
{
    /// @author  Shimels Alem proc_Fleet_SchduleLoadByPrimaryKey stored procedure.

    public class GetprocFleetSchduleByPrimaryKey : IRequest<GetprocFleetSchduleLoadAllListVm>
    {
        public System.Guid Fleet_SchduleID { get; set; }
    }
}
