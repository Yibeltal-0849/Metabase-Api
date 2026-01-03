using System.Collections.Generic;
using XOKA.Application.BSC.Quiries.AnnualStrategicGoals;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Quiries.AnnualStrategicGoals.GetAnnualStrategicGoalsLoadAll
{
    public class AnnualStrategicGoalsLoadAllListVm
    {
        public IList<AnnualStrategicGoalsLoadAllVm> AnnualStrategicGoals { get; set; }
    }
}
