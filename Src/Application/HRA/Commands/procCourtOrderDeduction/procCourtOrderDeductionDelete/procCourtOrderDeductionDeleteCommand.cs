 


using MediatR;
using System;
using XOKA.Domain.Entities.HRA;
using System.Collections.Generic;

namespace Application.HRA.Commands.procCourtOrderDeduction.procCourtOrderDeductionDelete.procCourtOrderDeductionDeleteCommand
{

    // @author  Shimels Alem  proc_Court_Order_DeductionDelete stored procedure.


    public class procCourtOrderDeductionDeleteCommand : IRequest<IList<CourtOrderDeduction_CourtOrderID>>
    {
        public System.Guid Court_Order_ID { get; set; }
    }
		
     
		
		 
}
 
 