using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.InventoryPostingGroup.InventoryPostingGroupUpdate.InventoryPostingGroupUpdateCommand
{

	/// @author  Shimels Alem  Inventory_Posting_GroupUpdate stored procedure.


	public class InventoryPostingGroupUpdateCommand : IRequest<IList<InventoryPostingGroup_Code>>
   {
		public string Code { get; set; }
		public string Description { get; set; }
		public bool? Active { get; set; }
	}
		
		
		 
}

