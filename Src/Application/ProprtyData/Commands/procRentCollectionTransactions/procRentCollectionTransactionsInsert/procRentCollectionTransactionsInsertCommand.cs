


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procRentCollectionTransactions.procRentCollectionTransactionsInsert.procRentCollectionTransactionsInsertCommand
{

	/// @author  Shimels Alem  proc_Rent_Collection_TransactionsInsert stored procedure.


	public class procRentCollectionTransactionsInsertCommand : IRequest<IList<RentCollectionTransactions>>
    {
        public System.Guid Rent_Collection_ID { get; set; }
        public System.DateTime? Period { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_date { get; set; }
        public bool? Generate { get; set; }
        public string Archived_Pay_Slip { get; set; }
    }
		
		
		 
}
 
 