 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cUnit.cUnitDelete.cUnitDeleteCommand
{

    // @author  Shimels Alem  c_UnitDelete stored procedure.


    public class cUnitDeleteCommand : IRequest<IList<CUnit_Unit>>
    {
        public string Unit { get; set; }
    }
		
     
		
		 
}
 
 