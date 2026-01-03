using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblVarableTables.GetproctblVarableTablesLoadAll;

namespace Application.ProprtyData.Queries.proctblVarableTables.GetproctblVarableTablesByPrimaryKey
{
    /// @author  Shimels Alem proc_tblVarable_TablesLoadByPrimaryKey stored procedure.

    public class GetproctblVarableTablesByPrimaryKey : IRequest<GetproctblVarableTablesLoadAllListVm>
    {
        public long id { get; set; }
    }
}
