using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdAccountingMethodUpdate.procAdAccountingMethodUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_Accounting_MethodUpdate stored procedure.
	 
	#region proc_Ad_Accounting_MethodUpdate  
     
  /// proc_Ad_Accounting_MethodUpdate stored procedure.
     
        public class procAdAccountingMethodUpdateCommand : IRequest<IList<AdAccountingMethod_Id>>
    {
    
		public long? id  { get; set; }
		public string name  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
