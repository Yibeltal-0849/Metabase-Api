 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cPayMethodscustomer.cPayMethodscustomerDelete.cPayMethodscustomerDeleteCommand
{

    // @author  Shimels Alem  c_Pay_Methods_customerDelete stored procedure.


    public class cPayMethodscustomerDeleteCommand : IRequest<IList<CPayMethodsCustomer_Id>>
    {
        public long Id { get; set; }
    }
		
     
		
		 
}
 
 