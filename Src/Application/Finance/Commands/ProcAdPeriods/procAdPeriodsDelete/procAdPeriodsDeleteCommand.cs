using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdPeriodsDelete.procAdPeriodsDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_PeriodsDelete stored procedure.
	 
	#region proc_Ad_PeriodsDelete  
     
  /// proc_Ad_PeriodsDelete stored procedure.
     
        public class procAdPeriodsDeleteCommand : IRequest<IList<AdPeriods_StartDate>>
    {
    
		public DateTime startDate  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
