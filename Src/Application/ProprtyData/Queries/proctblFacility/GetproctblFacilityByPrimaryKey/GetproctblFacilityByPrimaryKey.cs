using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblFacility.GetproctblFacilityLoadAll;

namespace Application.ProprtyData.Queries.proctblFacility.GetproctblFacilityByPrimaryKey
{
    /// @author  Shimels Alem proc_tblFacilityLoadByPrimaryKey stored procedure.

    public class GetproctblFacilityByPrimaryKey : IRequest<GetproctblFacilityLoadAllListVm>
    {
        public long id { get; set; }
    }
}
