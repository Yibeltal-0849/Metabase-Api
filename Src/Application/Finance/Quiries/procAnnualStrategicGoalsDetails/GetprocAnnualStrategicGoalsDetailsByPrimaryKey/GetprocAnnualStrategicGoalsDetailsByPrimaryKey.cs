using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procAnnualStrategicGoalsDetails.GetprocAnnualStrategicGoalsDetailsLoadAll;

namespace Application.Finance.Quiries.procAnnualStrategicGoalsDetails.GetprocAnnualStrategicGoalsDetailsByPrimaryKey
{
    /// @author  Shimels Alem  proc_Annual_Strategic_Goals_DetailsLoadByPrimaryKey stored procedure.

    public class GetprocAnnualStrategicGoalsDetailsByPrimaryKey : IRequest<GetprocAnnualStrategicGoalsDetailsLoadAllListVm>
    {
            public string ASGD_ID { get; set; }
    }
}
