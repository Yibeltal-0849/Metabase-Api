


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.ItemCategory.ItemCategoryInsert.ItemCategoryInsertCommand
{

    /// @author  Shimels Alem  Item_CategoryInsert stored procedure.


    public class ItemCategoryInsertCommand : IRequest<IList<Item_Category_Code>>
    {
		public string Code { get; set; }
		public string Description { get; set; }
		public string Gen_Pord_Posting_Group { get; set; }
		public string Inventory_Posting_Group { get; set; }
		public string TAX_Prod_Posting_Group { get; set; }
		public string Cost_Method { get; set; }
	}
		
		
		 
	}
 
 