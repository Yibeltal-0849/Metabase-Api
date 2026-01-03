using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.lkdetailDelete.lkdetailDeleteCommand
{ 
	 
	/// @author  Henok Solomon  lkdetail_Delete stored procedure.
	 
	#region lkdetail_Delete  
     
  /// lkdetail_Delete stored procedure.
     
        public class lkdetailDeleteCommand : IRequest<IList<lkdetail_lkdetail_Code>>
    {
    
		public System.Guid lkdetail_Code { get; set; }

    }
		
        #endregion
		
		 
	}
 
 
