 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.ItemType.ItemTypeDelete.ItemTypeDeleteCommand
{

    // @author  Shimels Alem  ItemTypeDelete stored procedure.


    public class ItemTypeDeleteCommand : IRequest<IList<ItemType_Name>>
    {
        public string Name { get; set; }
    }
		
     
		
		 
	}
 
 