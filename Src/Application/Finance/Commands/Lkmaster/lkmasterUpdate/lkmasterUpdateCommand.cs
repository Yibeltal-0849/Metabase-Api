using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.lkmasterUpdate.lkmasterUpdateCommand
{ 
	 
	/// @author  Henok Solomon  lkmaster_Update stored procedure.
	 
	#region lkmaster_Update  
     
  /// lkmaster_Update stored procedure.
     
        public class lkmasterUpdateCommand : IRequest<IList<lkmaster_lkmaster_Code>>
    {
        public System.Guid lkmaster_Code { get; set; }
        public string description { get; set; }
        public System.Guid parent { get; set; }

    }
		
        #endregion
		
		 
	}
 
 
