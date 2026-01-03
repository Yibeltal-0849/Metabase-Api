 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblVarableTables.proctblVarableTablesDelete.proctblVarableTablesDeleteCommand
{

    // @author  Shimels Alem  proc_tblVarable_TablesDelete stored procedure.


    public class proctblVarableTablesDeleteCommand : IRequest<IList<tblVarableTables_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 