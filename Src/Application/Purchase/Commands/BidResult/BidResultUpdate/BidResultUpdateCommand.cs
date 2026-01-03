using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Commands.BidResult.BidResultUpdate.BidResultUpdateCommand
{

	/// @author  Shimels Alem  Bid_ResultUpdate stored procedure.


	public class BidResultUpdateCommand : IRequest<IList<BidResult_BidResult>>
   {
		public System.Guid Bid_Result { get; set; }
		public string Participant_ID { get; set; }
		public bool? PreQulification_Is_Passed { get; set; }
		public double? Technical_Score { get; set; }
		public double? Financial_Score { get; set; }
		public double? Total_Rank { get; set; }
		public bool? Is_Approved { get; set; }
		public System.Guid? Document_ID { get; set; }
	}
		
		
		 
	}

