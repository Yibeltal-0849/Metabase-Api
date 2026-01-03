using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.StrategicInnitiative.GetStrategicInnitiativeLoadAll;

namespace Application.BSC.Quiries.StrategicInnitiative.GetprocStrategicInnitiativeLoadByPrimaryKeyASPAID
{
    /// @author  Shimels Alem  proc_Strategic_InnitiativeLoadByPrimaryKey_ASPA_ID stored procedure.

    public class GetprocStrategicInnitiativeLoadByPrimaryKeyASPAID : IRequest<GetStrategicInnitiativeLoadAllListVm>
    {
        public Guid ASPA_ID { get; set; }
    }
}
