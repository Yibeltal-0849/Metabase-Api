


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Commands.KPIGoalMappingDetail.KPIGoalMappingDetailInsert.KPIGoalMappingDetailInsertCommand
{

	/// @author  Shimels Alem  KPI_Goal_Mapping_DetailInsert stored procedure.


	public class KPIGoalMappingDetailInsertCommand : IRequest<IList<KPIGoalMappingDetail_Mapping_DetailID>>
    {
		public System.Guid? Mapping_DetailID { get; set; }
		public System.Guid KPIMapping_ID { get; set; }
		public System.Int32 Budget_Year { get; set; }
		public string Unit { get; set; }
		public long Value { get; set; }
	}
		
		
		 
	}
 
 