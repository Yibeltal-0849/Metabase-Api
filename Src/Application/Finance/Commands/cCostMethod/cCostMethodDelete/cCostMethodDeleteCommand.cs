 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cCostMethod.cCostMethodDelete.cCostMethodDeleteCommand
{

    // @author  Shimels Alem  c_Cost_MethodDelete stored procedure.


    public class cCostMethodDeleteCommand : IRequest<IList<CCostMethod_ID>>
    {
        public string ID { get; set; }
    }
		
     
		
		 
	}
 
 