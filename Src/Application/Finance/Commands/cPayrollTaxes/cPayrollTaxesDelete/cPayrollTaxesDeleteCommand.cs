 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cPayrollTaxes.cPayrollTaxesDelete.cPayrollTaxesDeleteCommand
{

    // @author  Shimels Alem  c_PayrollTaxesDelete stored procedure.


    public class cPayrollTaxesDeleteCommand : IRequest<IList<CPayrollTaxes_Id>>
    {
        public long Id { get; set; }
    }
		
     
		
		 
}
 
 