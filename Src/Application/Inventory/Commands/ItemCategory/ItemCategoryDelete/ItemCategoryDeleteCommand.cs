 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.ItemCategory.ItemCategoryDelete.ItemCategoryDeleteCommand
{

    // @author  Shimels Alem  Item_CategoryDelete stored procedure.


    public class ItemCategoryDeleteCommand : IRequest<IList<Item_Category_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
	}
 
 