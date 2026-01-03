using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.procRentCollection.procRentCollectionUpdate.procRentCollectionUpdateCommand
{

	/// @author  Shimels Alem  proc_Rent_CollectionUpdate stored procedure.


	public class procRentCollectionUpdateCommand : IRequest<IList<RentCollection_Month>>
	{
		public System.Guid Rent_Collection_ID { get; set; }
		public System.Guid Rent_Contract_ID { get; set; }
		public System.Guid Month { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_date { get; set; }
		public bool? Collected { get; set; }
		public string Referance_NO { get; set; }

	}
		
		
		 
}

