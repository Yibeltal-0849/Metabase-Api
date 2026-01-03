using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.AnnualStrategicGoalsDetailsGroupByPerspective.AnnualStrategicGoalsDetailsGroupByPerspectiveUpdate.AnnualStrategicGoalsDetailsGroupByPerspectiveUpdateCommand
{

	/// @author  Shimels Alem  Annual_Strategic_Goals_Details_GroupBy_PerspectiveUpdate stored procedure.


	public class AnnualStrategicGoalsDetailsGroupByPerspectiveUpdateCommand : IRequest<IList<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID>>
	{
		public System.Guid ASGDGP_ID { get; set; }
		public string Perspective_ID { get; set; }
		public string ASGD_ID { get; set; }
	}
		
		
		 
	}

