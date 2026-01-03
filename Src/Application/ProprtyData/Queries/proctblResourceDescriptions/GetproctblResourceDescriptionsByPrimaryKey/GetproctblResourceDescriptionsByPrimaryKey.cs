using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblResourceDescriptions.GetproctblResourceDescriptionsLoadAll;

namespace Application.ProprtyData.Queries.proctblResourceDescriptions.GetproctblResourceDescriptionsByPrimaryKey
{
    /// @author  Shimels Alem proc_tblResourceDescriptionsLoadByPrimaryKey stored procedure.

    public class GetproctblResourceDescriptionsByPrimaryKey : IRequest<GetproctblResourceDescriptionsLoadAllListVm>
    {
        public long id { get; set; }
    }
}
