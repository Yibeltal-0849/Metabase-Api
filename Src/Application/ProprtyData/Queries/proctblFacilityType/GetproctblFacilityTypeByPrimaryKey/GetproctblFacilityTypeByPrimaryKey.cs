using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblFacilityType.GetproctblFacilityTypeLoadAll;

namespace Application.ProprtyData.Queries.proctblFacilityType.GetproctblFacilityTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_tblFacility_TypeLoadByPrimaryKey stored procedure.

    public class GetproctblFacilityTypeByPrimaryKey : IRequest<GetproctblFacilityTypeLoadAllListVm>
    {
        public long id { get; set; }
    }
}
