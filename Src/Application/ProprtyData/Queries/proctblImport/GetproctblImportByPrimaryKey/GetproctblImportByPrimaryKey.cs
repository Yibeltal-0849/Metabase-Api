using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblImport.GetproctblImportLoadAll;

namespace Application.ProprtyData.Queries.proctblImport.GetproctblImportByPrimaryKey
{
    /// @author  Shimels Alem proc_tblImportLoadByPrimaryKey stored procedure.

    public class GetproctblImportByPrimaryKey : IRequest<GetproctblImportLoadAllListVm>
    {
        public long id { get; set; }
    }
}
