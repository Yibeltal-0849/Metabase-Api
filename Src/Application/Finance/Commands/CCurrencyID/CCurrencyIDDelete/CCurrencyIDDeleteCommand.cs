 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CCurrencyID.CCurrencyIDDelete.CCurrencyIDDeleteCommand
{

    // @author  Shimels Alem  C_Currency_IDDelete stored procedure.


    public class CCurrencyIDDeleteCommand : IRequest<IList<CCurrencyId_CurrencyID>>
    {
        public string CurrencyID { get; set; }
    }
		
     
		
		 
	}
 
 