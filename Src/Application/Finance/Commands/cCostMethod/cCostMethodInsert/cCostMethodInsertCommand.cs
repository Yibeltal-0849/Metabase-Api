


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cCostMethod.cCostMethodInsert.cCostMethodInsertCommand
{

    /// @author  Shimels Alem  c_Cost_MethodInsert stored procedure.


    public class cCostMethodInsertCommand : IRequest<IList<CCostMethod_ID>>
    {
        public string ID { get; set; }
        public string Name { get; set; }
    }
		
		
		 
	}
 
 