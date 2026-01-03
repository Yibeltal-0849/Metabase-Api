using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.procBSCValues.GetprocBSCValuesLoadAll;

namespace Application.BSC.Quiries.procBSCValues.GetprocBSCValuesByPrimaryKey
{
    /// @author  Shimels Alem proc_BSC_ValuesLoadByPrimaryKey stored procedure.

    public class GetprocBSCValuesByPrimaryKey : IRequest<GetprocBSCValuesLoadAllListVm>
    {
        public System.Guid BSC_Value_ID { get; set; }
    }
}
