 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Commands.KPIGoalMappingDetail.KPIGoalMappingDetailDelete.KPIGoalMappingDetailDeleteCommand
{

    // @author  Shimels Alem  KPI_Goal_Mapping_DetailDelete stored procedure.

    public class KPIGoalMappingDetailDeleteCommand : IRequest<IList<KPIGoalMappingDetail_Mapping_DetailID>>
    {
        public System.Guid Mapping_DetailID { get; set; }
    }
		
     
		
		 
	}
 
 