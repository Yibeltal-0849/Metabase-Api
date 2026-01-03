 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cTurmsAndCredit.cTurmsAndCreditDelete.cTurmsAndCreditDeleteCommand
{

    // @author  Shimels Alem  c_TurmsAndCreditDelete stored procedure.


    public class cTurmsAndCreditDeleteCommand : IRequest<IList<CTurmsAndCredit_Id>>
    {
        public long Id { get; set; }
    }
		
     
		
		 
}
 
 