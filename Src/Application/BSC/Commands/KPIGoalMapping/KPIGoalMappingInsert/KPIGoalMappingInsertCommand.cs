


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Commands.KPIGoalMapping.KPIGoalMappingInsert.KPIGoalMappingInsertCommand
{

	/// @author  Shimels Alem  KPI_Goal_MappingInsert stored procedure.

	public class KPIGoalMappingInsertCommand : IRequest<IList<KPIGoalMapping_KPIMapping_ID>>
    {
		public System.Guid? KPIMapping_ID { get; set; }
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
 
 