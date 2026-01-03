using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAnnualStrategicGoalsDetailsDelete.procAnnualStrategicGoalsDetailsDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Annual_Strategic_Goals_DetailsDelete stored procedure.
	 
	#region proc_Annual_Strategic_Goals_DetailsDelete  
     
  /// proc_Annual_Strategic_Goals_DetailsDelete stored procedure.
     
        public class procAnnualStrategicGoalsDetailsDeleteCommand : IRequest<IList<proc_AnnualStrategicGoalsDetails_ASGD_ID>>
    {
    
		public string asgd_Id  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
