 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Commands.AnnualStrategicGoalsDetails.AnnualStrategicGoalsDetailsDelete.AnnualStrategicGoalsDetailsDeleteCommand
{

    // @author  Shimels Alem  Annual_Strategic_Goals_DetailsDelete stored procedure.


    public class AnnualStrategicGoalsDetailsDeleteCommand : IRequest<IList<AnnualStrategicGoalsDetails_ASGD_ID>>
    {
        public string ASGD_ID { get; set; }
    }
		
     
		
		 
	}
 
 