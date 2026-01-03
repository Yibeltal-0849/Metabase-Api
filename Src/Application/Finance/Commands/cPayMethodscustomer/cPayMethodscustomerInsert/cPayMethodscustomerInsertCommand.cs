


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cPayMethodscustomer.cPayMethodscustomerInsert.cPayMethodscustomerInsertCommand
{

    /// @author  Shimels Alem  c_Pay_Methods_customerInsert stored procedure.


    public class cPayMethodscustomerInsertCommand : IRequest<IList<CPayMethodsCustomer_Id>>
    {
        public long? Id { get; set; }
        public string Customer_ID { get; set; }
        public long? Type { get; set; }
    }
		
		
		 
}
 
 