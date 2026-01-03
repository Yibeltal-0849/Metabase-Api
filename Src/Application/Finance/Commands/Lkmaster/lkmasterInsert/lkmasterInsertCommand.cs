using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.lkmasterInsert.lkmasterInsertCommand
{ 
	 
	/// @author  Henok Solomon  lkmaster_Insert stored procedure.
	 
	#region lkmaster_Insert  
     
  /// lkmaster_Insert stored procedure.
     
        public class lkmasterInsertCommand : IRequest<IList<lkmaster_lkmaster_Code>>
    {
    
		public System.Guid lkmaster_Code  { get; set; }
		public string description  { get; set; }
		public System.Guid parent  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
