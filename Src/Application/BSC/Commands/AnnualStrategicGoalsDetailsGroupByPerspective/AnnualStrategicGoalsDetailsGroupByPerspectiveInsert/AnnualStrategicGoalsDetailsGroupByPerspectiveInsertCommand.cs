


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Commands.AnnualStrategicGoalsDetailsGroupByPerspective.AnnualStrategicGoalsDetailsGroupByPerspectiveInsert.AnnualStrategicGoalsDetailsGroupByPerspectiveInsertCommand
{

    /// @author  Shimels Alem  Annual_Strategic_Goals_Details_GroupBy_PerspectiveInsert stored procedure.


    public class AnnualStrategicGoalsDetailsGroupByPerspectiveInsertCommand : IRequest<IList<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID>>
    {
        public System.Guid? ASGDGP_ID { get; set; }
        public string Perspective_ID { get; set; }
        public string ASGD_ID { get; set; }
    }
		
		
		 
	}
 
 