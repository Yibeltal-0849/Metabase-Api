using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblConsumption.GetproctblConsumptionLoadAll;

namespace Application.ProprtyData.Queries.proctblConsumption.GetproctblConsumptionByPrimaryKey
{
    /// @author  Shimels Alem proc_tblConsumptionLoadByPrimaryKey stored procedure.

    public class GetproctblConsumptionByPrimaryKey : IRequest<GetproctblConsumptionLoadAllListVm>
    {
        public long id { get; set; }
    }
}
