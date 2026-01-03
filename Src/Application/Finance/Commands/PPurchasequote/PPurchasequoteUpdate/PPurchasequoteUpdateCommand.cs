using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.PPurchasequote.PPurchasequoteUpdate.PPurchasequoteUpdateCommand
{

	/// @author  Shimels Alem  [P_Purchase quoteUpdate] stored procedure.


	public class PPurchasequoteUpdateCommand : IRequest<IList<PPurchaseQuote_Purchase_Line>>
   {
		public System.Guid Purchase_Line { get; set; }
		public int? Qty_to_Assign { get; set; }
		public int? Qty_Assigned { get; set; }
	}
		
		
		 
}

