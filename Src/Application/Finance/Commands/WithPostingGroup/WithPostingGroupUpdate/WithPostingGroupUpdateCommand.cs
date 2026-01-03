using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.WithPostingGroup.WithPostingGroupUpdate.WithPostingGroupUpdateCommand
{

	/// @author  Shimels Alem  With_Posting_GroupUpdate stored procedure.


	public class WithPostingGroupUpdateCommand : IRequest<IList<With_Posting_Group_Code>>
   {
		public string Code { get; set; }
		public string Description { get; set; }
		public Double Rate { get; set; }
	}
		
		
		 
}

