


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblVarableBasedTableDetail.proctblVarableBasedTableDetailInsert.proctblVarableBasedTableDetailInsertCommand
{

    /// @author  Shimels Alem  proc_tblVarableBasedTable_DetailInsert stored procedure.


    public class proctblVarableBasedTableDetailInsertCommand : IRequest<IList<tblVarableBasedTableDetail_id>>
    {
        public long? id { get; set; }
        public long Table_id { get; set; }
        public long EnergyChain_id { get; set; }
        public long Type_id { get; set; }
    }
		
		
		 
}
 
 