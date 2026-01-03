 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cPayType.cPayTypeDelete.cPayTypeDeleteCommand
{

    // @author  Shimels Alem  c_PayTypeDelete stored procedure.


    public class cPayTypeDeleteCommand : IRequest<IList<CPayType_PayType>>
    {
        public string PayType { get; set; }
    }
		
     
		
		 
}
 
 