using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblResourceFacility.GetproctblResourceFacilityLoadAll;

namespace Application.ProprtyData.Queries.proctblResourceFacility.GetproctblResourceFacilityByPrimaryKey
{
    /// @author  Shimels Alem proc_tblResource_FacilityLoadByPrimaryKey stored procedure.

    public class GetproctblResourceFacilityByPrimaryKey : IRequest<GetproctblResourceFacilityLoadAllListVm>
    {
        public long id { get; set; }
    }
}
