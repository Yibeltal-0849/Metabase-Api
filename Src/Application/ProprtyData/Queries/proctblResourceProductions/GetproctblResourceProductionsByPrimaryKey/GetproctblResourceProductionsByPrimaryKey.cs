using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblResourceProductions.GetproctblResourceProductionsLoadAll;

namespace Application.ProprtyData.Queries.proctblResourceProductions.GetproctblResourceProductionsByPrimaryKey
{
    /// @author  Shimels Alem proc_tblResourceProductionsLoadByPrimaryKey stored procedure.

    public class GetproctblResourceProductionsByPrimaryKey : IRequest<GetproctblResourceProductionsLoadAllListVm>
    {
        public long id { get; set; }
    }
}
