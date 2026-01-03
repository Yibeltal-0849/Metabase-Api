using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblVarableBasedTableDetail.GetproctblVarableBasedTableDetailLoadAll;

namespace Application.ProprtyData.Queries.proctblVarableBasedTableDetail.GetproctblVarableBasedTableDetailByPrimaryKey
{
    /// @author  Shimels Alem proc_tblVarableBasedTable_DetailLoadByPrimaryKey stored procedure.

    public class GetproctblVarableBasedTableDetailByPrimaryKey : IRequest<GetproctblVarableBasedTableDetailLoadAllListVm>
    {
        public long id { get; set; }
    }
}
