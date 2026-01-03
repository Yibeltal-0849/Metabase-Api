using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblSector.GetproctblSectorLoadAll;

namespace Application.ProprtyData.Queries.proctblSector.GetproctblSectorByPrimaryKey
{
    /// @author  Shimels Alem proc_tblSectorLoadByPrimaryKey stored procedure.

    public class GetproctblSectorByPrimaryKey : IRequest<GetproctblSectorLoadAllListVm>
    {
        public long id { get; set; }
    }
}
