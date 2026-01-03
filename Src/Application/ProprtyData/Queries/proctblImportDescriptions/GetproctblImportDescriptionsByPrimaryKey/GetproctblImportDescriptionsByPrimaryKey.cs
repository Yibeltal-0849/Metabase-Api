using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblImportDescriptions.GetproctblImportDescriptionsLoadAll;

namespace Application.ProprtyData.Queries.proctblImportDescriptions.GetproctblImportDescriptionsByPrimaryKey
{
    /// @author  Shimels Alem proc_tblImport_DescriptionsLoadByPrimaryKey stored procedure.

    public class GetproctblImportDescriptionsByPrimaryKey : IRequest<GetproctblImportDescriptionsLoadAllListVm>
    {
        public long id { get; set; }
    }
}
