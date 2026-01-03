using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.ItemCategory.ItemCategoryUpdate.ItemCategoryUpdateCommand
{

	/// @author  Shimels Alem  Item_CategoryUpdate stored procedure.


	public class ItemCategoryUpdateCommand : IRequest<IList<Item_Category_Code>>
   {
		public string Code { get; set; }
		public string Description { get; set; }
		public string Gen_Pord_Posting_Group { get; set; }
		public string Inventory_Posting_Group { get; set; }
		public string TAX_Prod_Posting_Group { get; set; }
		public string Cost_Method { get; set; }
	}
		
		
		 
	}

