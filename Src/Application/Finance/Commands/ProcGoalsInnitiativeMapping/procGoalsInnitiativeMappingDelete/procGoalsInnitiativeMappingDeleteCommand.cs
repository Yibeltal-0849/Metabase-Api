using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procGoalsInnitiativeMappingDelete.procGoalsInnitiativeMappingDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Goals_Innitiative_MappingDelete stored procedure.
	 
	#region proc_Goals_Innitiative_MappingDelete  
     
  /// proc_Goals_Innitiative_MappingDelete stored procedure.
     
        public class procGoalsInnitiativeMappingDeleteCommand : IRequest<IList<ProcGoalsInnitiativeMapping_innitiativeMapping_ID>>
    {
    
		public System.Guid innitiativeMapping_ID { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
