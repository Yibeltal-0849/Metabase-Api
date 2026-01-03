using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.AnnualStrategicGoalsDetails.AnnualStrategicGoalsDetailsUpdate.AnnualStrategicGoalsDetailsUpdateCommand
{

	/// @author  Shimels Alem  Annual_Strategic_Goals_DetailsUpdate stored procedure.


	public class AnnualStrategicGoalsDetailsUpdateCommand : IRequest<IList<AnnualStrategicGoalsDetails_ASGD_ID>>
	{
		public string ASGD_ID { get; set; }
		public string Annual_Strategic_GoalID { get; set; }
		public string Strategic_Goal { get; set; }
		public System.Double? Goal_Value_In_Per { get; set; }
		public string Goal_Description { get; set; }
	}
		
		
		 
	}

