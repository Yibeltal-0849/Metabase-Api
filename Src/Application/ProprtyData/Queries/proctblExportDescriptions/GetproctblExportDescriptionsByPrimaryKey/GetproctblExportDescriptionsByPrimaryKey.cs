using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblExportDescriptions.GetproctblExportDescriptionsLoadAll;

namespace Application.ProprtyData.Queries.proctblExportDescriptions.GetproctblExportDescriptionsByPrimaryKey
{
    /// @author  Shimels Alem proc_tblExport_DescriptionsLoadByPrimaryKey stored procedure.

    public class GetproctblExportDescriptionsByPrimaryKey : IRequest<GetproctblExportDescriptionsLoadAllListVm>
    {
        public long id { get; set; }
    }
}
