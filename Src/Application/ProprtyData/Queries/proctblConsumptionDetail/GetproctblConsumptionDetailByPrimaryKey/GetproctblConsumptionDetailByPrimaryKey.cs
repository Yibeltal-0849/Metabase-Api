using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblConsumptionDetail.GetproctblConsumptionDetailLoadAll;

namespace Application.ProprtyData.Queries.proctblConsumptionDetail.GetproctblConsumptionDetailByPrimaryKey
{
    /// @author  Shimels Alem proc_tblConsumption_DetailLoadByPrimaryKey stored procedure.

    public class GetproctblConsumptionDetailByPrimaryKey : IRequest<GetproctblConsumptionDetailLoadAllListVm>
    {
        public long id { get; set; }
    }
}
