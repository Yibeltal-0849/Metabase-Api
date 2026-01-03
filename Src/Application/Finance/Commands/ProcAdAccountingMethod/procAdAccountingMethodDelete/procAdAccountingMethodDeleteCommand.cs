using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdAccountingMethodDelete.procAdAccountingMethodDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_Accounting_MethodDelete stored procedure.
	 
	#region proc_Ad_Accounting_MethodDelete  
     
  /// proc_Ad_Accounting_MethodDelete stored procedure.
     
        public class procAdAccountingMethodDeleteCommand : IRequest<IList<AdAccountingMethod_Id>>
    {
		public long id  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
