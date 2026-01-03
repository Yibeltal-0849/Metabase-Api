 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblVarableBasedTables.proctblVarableBasedTablesDelete.proctblVarableBasedTablesDeleteCommand
{

    // @author  Shimels Alem  proc_tblVarableBasedTablesDelete stored procedure.


    public class proctblVarableBasedTablesDeleteCommand : IRequest<IList<tblVarableBasedTables_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 