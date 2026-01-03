 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CTax.CTaxDelete.CTaxDeleteCommand
{

    // @author  Shimels Alem  C_TaxDelete stored procedure.


    public class CTaxDeleteCommand : IRequest<IList<CTax_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 