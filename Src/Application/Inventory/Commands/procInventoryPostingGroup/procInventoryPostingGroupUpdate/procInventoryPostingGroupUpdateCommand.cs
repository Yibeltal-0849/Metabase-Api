using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.procInventoryPostingGroup.procInventoryPostingGroupUpdate.procInventoryPostingGroupUpdateCommand
{

	/// @author  Shimels Alem  proc_Inventory_Posting_GroupUpdate stored procedure.


	public class procInventoryPostingGroupUpdateCommand : IRequest<IList<InventoryPostingGroup_Code>>
   {
		public string Code { get; set; }
		public string Description { get; set; }
		public bool? Active { get; set; }
	}
		
		
		 
}

