using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.SSalseqoute.SSalseqouteUpdate.SSalseqouteUpdateCommand
{

	/// @author  Shimels Alem  S_Salse_qouteUpdate stored procedure.


	public class SSalseqouteUpdateCommand : IRequest<IList<SSalseQoute_Sales_Qoute_Line_ID>>
   {
		public string Sales_Qoute_Line_ID { get; set; }
		public int? Qty_to_Assign { get; set; }
		public int? Qty_Assigned { get; set; }
	}
		
		
		 
}

