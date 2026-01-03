using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.KPIGoalMappingDetail.KPIGoalMappingDetailUpdate.KPIGoalMappingDetailUpdateCommand
{

	/// @author  Shimels Alem  KPI_Goal_Mapping_DetailUpdate stored procedure.

	public class KPIGoalMappingDetailUpdateCommand : IRequest<IList<KPIGoalMappingDetail_Mapping_DetailID>>
   {
		public System.Guid Mapping_DetailID { get; set; }
		public System.Guid KPIMapping_ID { get; set; }
		public System.Int32 Budget_Year { get; set; }
		public string Unit { get; set; }
		public long Value { get; set; }
	}
		
		
		 
	}

