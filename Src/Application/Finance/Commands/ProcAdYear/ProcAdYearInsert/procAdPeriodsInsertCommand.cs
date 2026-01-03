using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.ProcAdYearInsert.ProcAdYearInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_PeriodsInsert stored procedure.
	 
	#region proc_Ad_PeriodsInsert  
     
  /// proc_Ad_PeriodsInsert stored procedure.
     
        public class ProcAdYearInsertCommand : IRequest<IList<ProcAdYearId>>
    {
        public string Year { get; set; }
        public string Org { get; set; }
        public string Calander { get; set; }
        public bool? IsActive { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
