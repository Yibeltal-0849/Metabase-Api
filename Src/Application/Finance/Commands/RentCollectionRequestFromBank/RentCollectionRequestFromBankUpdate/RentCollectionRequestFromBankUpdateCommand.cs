using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.RentCollectionRequestFromBank.RentCollectionRequestFromBankUpdate.RentCollectionRequestFromBankUpdateCommand
{

	/// @author  Shimels Alem  C_Currency_IDUpdate stored procedure.


	public class RentCollectionRequestFromBankUpdateCommand : IRequest<IList<RentCollectionRequestFromBankID>>
   {
		public string Application_NO { get; set; }
		public string Referance_Number { get; set; }
		public double Amount { get; set; }
		public string Currency { get; set; }
		public System.DateTime @RequestDate { get; set; }
		public bool Is_Paid { get; set; }
		public System.DateTime Paid_Date { get; set; }
		public string PayTicket_NO { get; set; }
		public System.DateTime TimeStamp { get; set; }
	}
		
		
		 
	}

