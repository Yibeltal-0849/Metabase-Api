using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procGoalsInnitiativeMappingUpdate.procGoalsInnitiativeMappingUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Goals_Innitiative_MappingUpdate stored procedure.
	 
	#region proc_Goals_Innitiative_MappingUpdate  
     
  /// proc_Goals_Innitiative_MappingUpdate stored procedure.
     
        public class procGoalsInnitiativeMappingUpdateCommand : IRequest<IList<ProcGoalsInnitiativeMapping_innitiativeMapping_ID>>
    {

		public System.Guid innitiativeMapping_ID { get; set; }
		public System.Guid? strategic_GoalID { get; set; }
		public string innitiative_ID { get; set; }
		public string scope { get; set; }
		public string expected_Result { get; set; }
		public string required_Inputs { get; set; }
		public string performer { get; set; }
	}
		
        #endregion
		
		 
	}
 
 
