using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblExport.GetproctblExportLoadAll;

namespace Application.ProprtyData.Queries.proctblExport.GetproctblExportByPrimaryKey
{
    /// @author  Shimels Alem proc_tblExportLoadByPrimaryKey stored procedure.

    public class GetproctblExportByPrimaryKey : IRequest<GetproctblExportLoadAllListVm>
    {
        public long id { get; set; }
    }
}
