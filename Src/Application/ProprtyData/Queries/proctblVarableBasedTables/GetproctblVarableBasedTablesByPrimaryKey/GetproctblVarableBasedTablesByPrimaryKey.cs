using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblVarableBasedTables.GetproctblVarableBasedTablesLoadAll;

namespace Application.ProprtyData.Queries.proctblVarableBasedTables.GetproctblVarableBasedTablesByPrimaryKey
{
    /// @author  Shimels Alem proc_tblVarableBasedTablesLoadByPrimaryKey stored procedure.

    public class GetproctblVarableBasedTablesByPrimaryKey : IRequest<GetproctblVarableBasedTablesLoadAllListVm>
    {
        public long id { get; set; }
    }
}
