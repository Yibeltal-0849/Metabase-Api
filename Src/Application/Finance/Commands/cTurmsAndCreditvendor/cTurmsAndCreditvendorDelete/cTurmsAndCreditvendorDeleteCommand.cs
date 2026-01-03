 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cTurmsAndCreditvendor.cTurmsAndCreditvendorDelete.cTurmsAndCreditvendorDeleteCommand
{

    // @author  Shimels Alem  c_TurmsAndCredit_vendorDelete stored procedure.


    public class cTurmsAndCreditvendorDeleteCommand : IRequest<IList<CTurmsAndCreditVendor_Id>>
    {
        public long Id { get; set; }
    }
		
     
		
		 
}
 
 