using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proclkMasterUpdate.proclkMasterUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_lkMasterUpdate stored procedure.
	 
	#region proc_lkMasterUpdate  
     
  /// proc_lkMasterUpdate stored procedure.
     
        public class proclkMasterUpdateCommand : IRequest<IList<lkmaster_lkmaster_Code>>
    {
    
 
		public System.Guid? lkmaster_Code { get; set; }
		public string description;
		public System.Guid? parent; 
    }
		
        #endregion
		
		 
	}
 
 
