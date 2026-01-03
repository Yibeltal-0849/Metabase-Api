using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.GenProductPostingGroup.GenProductPostingGroupUpdate.GenProductPostingGroupUpdateCommand
{

	/// @author  Shimels Alem  Gen_Product_Posting_GroupUpdate stored procedure.


	public class GenProductPostingGroupUpdateCommand : IRequest<IList<GenProductPostingGroup_Code>>
   {
		public string Code { get; set; }
		public string Description { get; set; }
		public string Def_VAT_Prod_Posting_Group { get; set; }
	}
		
		
		 
}

