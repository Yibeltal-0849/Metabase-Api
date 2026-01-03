using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.StrategicInnitiative.GetStrategicInnitiativeLoadAll;

namespace Application.BSC.Quiries.StrategicInnitiative.GetprocStrategicInnitiativeLoadByPrimaryKeyparentInnitiativeID
{
    /// @author  Shimels Alem  proc_Strategic_InnitiativeLoadByPrimaryKey_ASPA_ID stored procedure.

    public class GetprocStrategicInnitiativeLoadByPrimaryKeyparentInnitiativeID : IRequest<GetStrategicInnitiativeLoadAllListVm>
    {
        public string ParentInnitiative_ID { get; set; }
    }
}
