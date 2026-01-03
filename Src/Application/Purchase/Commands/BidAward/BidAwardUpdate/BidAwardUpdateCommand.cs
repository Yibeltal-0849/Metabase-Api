using AutoMapper;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Commands.BidAward.BidAwardUpdate.BidAwardUpdateCommand
{

	/// @author  Shimels Alem  proc_Bid_AwardUpdate stored procedure.


	public class BidAwardUpdateCommand : IRequest<IList<Bid_Award_Bid_Award_ID>>
   {
		public System.Guid Bid_Award_ID { get; set; }
		public System.Guid? Bid_Result { get; set; }
		public string Award_Letter_Number { get; set; }
		public double? Award_Amount_Inc_VAT { get; set; }
		public string Currency { get; set; }
		public System.Guid? Bid_Award_Status { get; set; }
		public string Remark { get; set; }
		public System.Guid? created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public System.DateTime? Updated_Date { get; set; }
	}
		
		
		 
	}

