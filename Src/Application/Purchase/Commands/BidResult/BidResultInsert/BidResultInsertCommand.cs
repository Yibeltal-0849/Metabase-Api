


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.BidResult.BidResultInsert.BidResultInsertCommand
{

	/// @author  Shimels Alem  Bid_ResultInsert stored procedure.


	public class BidResultInsertCommand : IRequest<IList<BidResult_BidResult>>
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
 
 