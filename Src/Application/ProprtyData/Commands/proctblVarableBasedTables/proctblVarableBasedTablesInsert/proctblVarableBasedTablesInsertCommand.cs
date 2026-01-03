


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblVarableBasedTables.proctblVarableBasedTablesInsert.proctblVarableBasedTablesInsertCommand
{

    /// @author  Shimels Alem  proc_tblVarableBasedTablesInsert stored procedure.


    public class proctblVarableBasedTablesInsertCommand : IRequest<IList<tblVarableBasedTables_id>>
    {
        public long? id { get; set; }
        public string Name { get; set; }
        public string Type_Table_Name { get; set; }
    }
		
		
		 
}
 
 