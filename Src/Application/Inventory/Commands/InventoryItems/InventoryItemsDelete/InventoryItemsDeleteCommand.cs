 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.InventoryItems.InventoryItemsDelete.InventoryItemsDeleteCommand
{

    // @author  Shimels Alem  Inventory_ItemsDelete stored procedure.


    public class InventoryItemsDeleteCommand : IRequest<IList<Inventory_Items_Inv_ID>>
    {
        public string Inv_ID { get; set; }
    }
		
     
		
		 
	}
 
 