 


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Commands.KPIGoalMapping.KPIGoalMappingDelete.KPIGoalMappingDeleteCommand
{

    // @author  Shimels Alem  KPI_Goal_MappingDelete stored procedure.

    public class KPIGoalMappingDeleteCommand : IRequest<IList<KPIGoalMapping_KPIMapping_ID>>
    {
        public System.Guid KPIMapping_ID { get; set; }
    }
		
		 
}
 
 