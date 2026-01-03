using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.procKPIGoalMapping.GetprocKPIGoalMappingLoadAll;

namespace Application.BSC.Quiries.procKPIGoalMapping.GetprocKPIGoalMappingByPrimaryKey
{
    /// @author  Shimels Alem proc_KPI_Goal_MappingLoadByPrimaryKey stored procedure.

    public class GetprocKPIGoalMappingByPrimaryKey : IRequest<GetprocKPIGoalMappingLoadAllListVm>
    {
        public System.Guid KPIMapping_ID { get; set; }
    }
}
