


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cUnit.cUnitInsert.cUnitInsertCommand
{

    /// @author  Shimels Alem  c_UnitInsert stored procedure.


    public class cUnitInsertCommand : IRequest<IList<CUnit_Unit>>
    {
        public string Unit { get; set; }
        public string Description { get; set; }
    }
		
		
		 
}
 
 