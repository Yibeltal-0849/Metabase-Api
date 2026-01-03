 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Entities.Finance;

namespace Application.BSC.Commands.AnnualStrategicGoalsDetailsGroupByPerspective.AnnualStrategicGoalsDetailsGroupByPerspectiveDelete.AnnualStrategicGoalsDetailsGroupByPerspectiveDeleteCommand
{

    // @author  Shimels Alem  Annual_Strategic_Goals_Details_GroupBy_PerspectiveDelete stored procedure.


    public class AnnualStrategicGoalsDetailsGroupByPerspectiveDeleteCommand : IRequest<IList<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID>>
    {
        public System.Guid ASGDGP_ID { get; set; }
    }
		
     
		
		 
	}
 
 