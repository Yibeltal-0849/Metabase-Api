using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Purchase;
using XOKA.Domain.Interfaces;

namespace Application.Purchase.Commands.BidDetail.BidDetailUpdate.BidDetailUpdateCommand
{

	/// @author  Shimels Alem  proc_Bid_DetailUpdate stored procedure.


	public class BidDetailUpdateCommand : IRequest<IList<Bid_Detail_Bid_DetailID>>
   {
		public System.Guid Bid_DetailID { get; set; }
		public System.Guid? Bid_Detail_ID { get; set; }
		public System.Guid? Budget_ID { get; set; }
		public string PO_ID { get; set; }
		public int? Lot_No { get; set; }
		public string Name { get; set; }
		public string Innitiative_ID { get; set; }
		public string Budget_Detail_ID { get; set; }
		public byte[] Document { get; set; }
		public string Document_Description { get; set; }
		public string Bid_Section { get; set; }
		public double? Lot_Price { get; set; }
		public double? Bid_Security_ETB { get; set; }
		public System.DateTime? Bid_Security_untill { get; set; }
        public string bid_Description { get; set; }
    }
		
		
		 
	}

