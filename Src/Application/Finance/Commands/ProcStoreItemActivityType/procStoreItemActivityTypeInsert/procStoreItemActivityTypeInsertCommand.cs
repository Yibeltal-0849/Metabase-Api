using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procStoreItemActivityTypeInsert.procStoreItemActivityTypeInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_Store_Item_Activity_TypeInsert stored procedure.
	 
	#region proc_Store_Item_Activity_TypeInsert  
     
  /// proc_Store_Item_Activity_TypeInsert stored procedure.
     
        public class procStoreItemActivityTypeInsertCommand : IRequest<IList<Store_Item_Activity_Type_Code>>
    {
    
		public string code  { get; set; }
		public string name  { get; set; }
		public string iD_Numbring  { get; set; }
		public string jsonMeta_For_Detail  { get; set; }
		public System.Guid? visable_For_Task_ID  { get; set; }
		public string  order  { get; set; }
		public string group  { get; set; }
		public string mandatory_Column_Name  { get; set; }
		public bool? isActive  { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
