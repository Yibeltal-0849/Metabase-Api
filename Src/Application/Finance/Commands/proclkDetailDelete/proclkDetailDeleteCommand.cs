using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proclkDetailDelete.proclkDetailDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_lkDetailDelete stored procedure.
	 
	#region proc_lkDetailDelete  
     
  /// proc_lkDetailDelete stored procedure.
     
        public class proclkDetailDeleteCommand : IRequest<IList<lkdetail_lkdetail_Code>>
    {
    
		public System.Guid lkdetail_code { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
