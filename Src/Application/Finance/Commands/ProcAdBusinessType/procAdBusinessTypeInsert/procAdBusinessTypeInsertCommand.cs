using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdBusinessTypeInsert.procAdBusinessTypeInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_Business_TypeInsert stored procedure.
	 
	#region proc_Ad_Business_TypeInsert  
     
  /// proc_Ad_Business_TypeInsert stored procedure.
     
        public class procAdBusinessTypeInsertCommand : IRequest<IList<AdBusinessType_Id>>
    {
    
		public long? id  { get; set; }
		public string name  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
