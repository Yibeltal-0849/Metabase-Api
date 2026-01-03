using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proclkMasterDelete.proclkMasterDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_lkMasterDelete stored procedure.
	 
	#region proc_lkMasterDelete  
     
  /// proc_lkMasterDelete stored procedure.
     
        public class proclkMasterDeleteCommand : IRequest<IList<lkmaster_lkmaster_Code>>
    {
    
 		public System.Guid? lkmaster_Code { get; set; } 
    }
		
        #endregion
		
		 
	}
 
 
