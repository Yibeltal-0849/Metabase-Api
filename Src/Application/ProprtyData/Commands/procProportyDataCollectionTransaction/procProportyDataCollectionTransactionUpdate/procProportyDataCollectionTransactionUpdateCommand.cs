using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.procProportyDataCollectionTransaction.procProportyDataCollectionTransactionUpdate.procProportyDataCollectionTransactionUpdateCommand
{

	/// @author  Shimels Alem  proc_Rent_CollectionUpdate stored procedure.


	public class procProportyDataCollectionTransactionUpdateCommand : IRequest<IList<Proporty_Data_Collection_TransactionID>>
	{
		public System.Guid Trans_ID { get; set; }
		public string Property_ID { get; set; }
		public Nullable<System.DateTime> Transaction_Date { get; set; }
		public Nullable<System.Guid> Collected_by_user { get; set; }
		public string Dinamic_Form_Data { get; set; }
		public Nullable<bool> Approved { get; set; }
		public string Location { get; set; }

	}
		
		
		 
}

