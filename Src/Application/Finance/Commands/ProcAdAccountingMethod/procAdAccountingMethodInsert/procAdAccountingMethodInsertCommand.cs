using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdAccountingMethodInsert.procAdAccountingMethodInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_Accounting_MethodInsert stored procedure.
	 
	#region proc_Ad_Accounting_MethodInsert  
     
  /// proc_Ad_Accounting_MethodInsert stored procedure.
     
        public class procAdAccountingMethodInsertCommand : IRequest<IList<AdAccountingMethod_Id>>
    {
    
		public long? id  { get; set; }
		public string name  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
