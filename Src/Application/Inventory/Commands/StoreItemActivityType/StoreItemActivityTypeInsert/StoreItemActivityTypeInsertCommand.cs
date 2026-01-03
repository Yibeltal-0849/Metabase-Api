


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.StoreItemActivityType.StoreItemActivityTypeInsert.StoreItemActivityTypeInsertCommand
{

    /// @author  Shimels Alem  Store_Item_Activity_TypeInsert stored procedure.


    public class StoreItemActivityTypeInsertCommand : IRequest<IList<Store_Item_Activity_Type_Code>>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string ID_Numbring { get; set; }
        public string JsonMeta_For_Detail { get; set; }
        public System.Guid? Visable_For_Task_ID { get; set; }
        public string Order { get; set; }
        public string Mandatory_Column_Name { get; set; }
        public bool? IsActive { get; set; }
    }
		
		
		 
	}
 
 