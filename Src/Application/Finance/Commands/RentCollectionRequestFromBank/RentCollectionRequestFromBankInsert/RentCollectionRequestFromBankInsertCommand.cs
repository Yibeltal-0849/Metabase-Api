


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.RentCollectionRequestFromBank.RentCollectionRequestFromBankInsert.RentCollectionRequestFromBankInsertCommand
{

    /// @author  Shimels Alem  C_Currency_IDInsert stored procedure.


    public class RentCollectionRequestFromBankInsertCommand : IRequest<IList<RentCollectionRequestFromBankID>>
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
 
 