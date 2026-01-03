using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procorganizationTypeInsert.procorganizationTypeInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_organization_TypeInsert stored procedure.
	 
	#region proc_organization_TypeInsert  
     
  /// proc_organization_TypeInsert stored procedure.
     
        public class procorganizationTypeInsertCommand : IRequest<IList<procorganizationType_organization_Type_Code>>
    {
     
		public System.Guid organization_Type_Code  { get; set; }
		public string description_En  { get; set; }
		public string description_Am  { get; set; }
		public string description_Or  { get; set; }
		public string description_Tg  { get; set; } 
    }
		
        #endregion
		
		 
	}
 
 
