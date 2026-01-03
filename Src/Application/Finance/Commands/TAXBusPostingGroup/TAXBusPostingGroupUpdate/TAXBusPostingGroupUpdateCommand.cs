using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.TAXBusPostingGroup.TAXBusPostingGroupUpdate.TAXBusPostingGroupUpdateCommand
{

	/// @author  Shimels Alem  TAX_Bus_Posting_GroupUpdate stored procedure.


	public class TAXBusPostingGroupUpdateCommand : IRequest<IList<TAX_Bus_Posting_Group_Code>>
   {
		public string Code { get; set; }
		public string Description { get; set; }
		public bool? Active { get; set; }
	}
		
		
		 
}

