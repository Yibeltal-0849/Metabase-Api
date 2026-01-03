using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblResource.GetproctblResourceLoadAll;

namespace Application.ProprtyData.Queries.proctblResource.GetproctblResourceByPrimaryKey
{
    /// @author  Shimels Alem proc_tblResourceLoadByPrimaryKey stored procedure.

    public class GetproctblResourceByPrimaryKey : IRequest<GetproctblResourceLoadAllListVm>
    {
        public long id { get; set; }
    }
}
