 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.RentCollectionRequestFromBank.RentCollectionRequestFromBankDelete.RentCollectionRequestFromBankDeleteCommand
{

    // @author  Shimels Alem  C_Currency_IDDelete stored procedure.


    public class RentCollectionRequestFromBankDeleteCommand : IRequest<IList<RentCollectionRequestFromBankID>>
    {
        public string Application_NO { get; set; }
    }
		
     
		
		 
	}
 
 