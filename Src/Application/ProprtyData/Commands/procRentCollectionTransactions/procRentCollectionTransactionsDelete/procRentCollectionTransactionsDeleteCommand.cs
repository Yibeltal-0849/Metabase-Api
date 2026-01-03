 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procRentCollectionTransactions.procRentCollectionTransactionsDelete.procRentCollectionTransactionsDeleteCommand
{

    // @author  Shimels Alem  proc_Rent_Collection_TransactionsDelete stored procedure.


    public class procRentCollectionTransactionsDeleteCommand : IRequest<IList<RentCollectionTransactions>>
    {
        public System.Guid Rent_Collection_ID { get; set; }
    }
		 
}
 
 