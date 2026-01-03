using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblFaclitiyDescription.GetproctblFaclitiyDescriptionLoadAll;

namespace Application.ProprtyData.Queries.proctblFaclitiyDescription.GetproctblFaclitiyDescriptionByPrimaryKey
{
    /// @author  Shimels Alem proc_tblFaclitiy_DescriptionLoadByPrimaryKey stored procedure.

    public class GetproctblFaclitiyDescriptionByPrimaryKey : IRequest<GetproctblFaclitiyDescriptionLoadAllListVm>
    {
        public long id { get; set; }
    }
}
