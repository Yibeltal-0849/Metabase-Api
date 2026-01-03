


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procRentCollection.procRentCollectionInsert.procRentCollectionInsertCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionInsert stored procedure.


    public class procRentCollectionInsertCommand : IRequest<IList<RentCollection_Month>>
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
 
 