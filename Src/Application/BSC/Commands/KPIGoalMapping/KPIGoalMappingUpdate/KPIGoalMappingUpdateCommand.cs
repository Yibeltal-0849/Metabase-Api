using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.KPIGoalMapping.KPIGoalMappingUpdate.KPIGoalMappingUpdateCommand
{

	/// @author  Shimels Alem  KPI_Goal_MappingUpdate stored procedure.


	public class KPIGoalMappingUpdateCommand : IRequest<IList<KPIGoalMapping_KPIMapping_ID>>
   {
		public System.Guid KPIMapping_ID { get; set; }
		public System.Guid? KPI_ID { get; set; }
		public string Innitiative_ID { get; set; }
		public Double? BaseLine { get; set; }
		public Double? Target { get; set; }
		public Double? MIN { get; set; }
		public Double? MAX { get; set; }
		public Double? Value { get; set; }
		public Double? Weight { get; set; }
		public Double? Accomplished_Per { get; set; }
		public Double? Varance { get; set; }
	}
		
}

