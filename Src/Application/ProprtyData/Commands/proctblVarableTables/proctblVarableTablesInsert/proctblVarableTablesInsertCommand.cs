


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblVarableTables.proctblVarableTablesInsert.proctblVarableTablesInsertCommand
{

    /// @author  Shimels Alem  proc_tblVarable_TablesInsert stored procedure.


    public class proctblVarableTablesInsertCommand : IRequest<IList<tblVarableTables_id>>
    {
        public long? id { get; set; }
        public long? Variable_id { get; set; }
        public long? VarB_Table_Detail_id { get; set; }
    }
		
		
		 
}
 
 