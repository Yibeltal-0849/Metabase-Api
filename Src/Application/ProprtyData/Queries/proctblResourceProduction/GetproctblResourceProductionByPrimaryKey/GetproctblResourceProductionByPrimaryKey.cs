using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblResourceProduction.GetproctblResourceProductionLoadAll;

namespace Application.ProprtyData.Queries.proctblResourceProduction.GetproctblResourceProductionByPrimaryKey
{
    /// @author  Shimels Alem proc_tblResourceProductionLoadByPrimaryKey stored procedure.

    public class GetproctblResourceProductionByPrimaryKey : IRequest<GetproctblResourceProductionLoadAllListVm>
    {
        public long Facility_id { get; set; }
        public long Variable_id { get; set; }
        public System.DateTime Production_Period { get; set; }
    }
}
