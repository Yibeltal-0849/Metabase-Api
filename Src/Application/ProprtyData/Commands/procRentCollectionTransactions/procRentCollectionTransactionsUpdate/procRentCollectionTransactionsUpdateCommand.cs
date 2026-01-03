using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procRentCollectionTransactions.procRentCollectionTransactionsUpdate.procRentCollectionTransactionsUpdateCommand
{ 
	 
	/// @author  Shimels Alem  XXXX stored procedure.
	 
    
       public class procRentCollectionTransactionsUpdateCommand : IRequest<IList<RentCollectionTransactions>>
   {
        public System.Guid Rent_Collection_ID { get; set; }
        public System.DateTime? Period { get; set; }
        public System.DateTime? Start_Date { get; set; }
        public System.DateTime? End_date { get; set; }
        public bool? Generate { get; set; }
        public string Archived_Pay_Slip { get; set; }
    }
		
		
		 
}

