using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.GenBusPostingGroups.GenBusPostingGroupsUpdate.GenBusPostingGroupsUpdateCommand
{

	/// @author  Shimels Alem  Gen_Bus_Posting_GroupsUpdate stored procedure.


	public class GenBusPostingGroupsUpdateCommand : IRequest<IList<GenBusPostingGroups_Code>>
   {
		public string Code { get; set; }
		public string Description { get; set; }
		public string Def_VATBusPostingGroup { get; set; }
	}
		
		
		 
}

