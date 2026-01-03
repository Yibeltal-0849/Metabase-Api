using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblSubSectors.GetproctblSubSectorsLoadAll;

namespace Application.ProprtyData.Queries.proctblSubSectors.GetproctblSubSectorsByPrimaryKey
{
    /// @author  Shimels Alem proc_tblSubSectorsLoadByPrimaryKey stored procedure.

    public class GetproctblSubSectorsByPrimaryKey : IRequest<GetproctblSubSectorsLoadAllListVm>
    {
        public long id { get; set; }
    }
}
