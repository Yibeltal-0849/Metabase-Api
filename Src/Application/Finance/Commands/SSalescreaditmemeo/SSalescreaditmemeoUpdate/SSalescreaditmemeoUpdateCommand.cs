using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.SSalescreaditmemeo.SSalescreaditmemeoUpdate.SSalescreaditmemeoUpdateCommand
{

	/// @author  Shimels Alem  S_Sales_creadit_memeoUpdate stored procedure.


	public class SSalescreaditmemeoUpdateCommand : IRequest<IList<SSalesCreaditMemeo_Sales_Credit_Line_Id>>
   {
		public string Sales_Credit_Line_Id { get; set; }
		public int? Qty_to_Assign { get; set; }
		public int? Qty_Assigned { get; set; }
	}
		
		
		 
}

