


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Commands.AnnualStrategicGoalsDetails.AnnualStrategicGoalsDetailsInsert.AnnualStrategicGoalsDetailsInsertCommand
{

	/// @author  Shimels Alem  Annual_Strategic_Goals_DetailsInsert stored procedure.


	public class AnnualStrategicGoalsDetailsInsertCommand : IRequest<IList<AnnualStrategicGoalsDetails_ASGD_ID>>
    {
		public string ASGD_ID { get; set; }
		public string Annual_Strategic_GoalID { get; set; }
		public string Strategic_Goal { get; set; }
		public System.Double? Goal_Value_In_Per { get; set; }
		public string Goal_Description { get; set; }
	}
		
		
		 
	}
 
 