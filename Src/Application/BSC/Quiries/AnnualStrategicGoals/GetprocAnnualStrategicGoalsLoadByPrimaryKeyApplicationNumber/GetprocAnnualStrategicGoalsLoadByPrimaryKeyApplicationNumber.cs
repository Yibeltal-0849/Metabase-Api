using Application.BSC.Quiries.AnnualStrategicGoals.GetAnnualStrategicGoalsLoadAll; 
using MediatR;

namespace XOKA.Application.Finance.Quiries.AnnualStrategicGoals.GetprocAnnualStrategicGoalsLoadByPrimaryKeyApplicationNumber
{
    public class GetprocAnnualStrategicGoalsLoadByPrimaryKeyApplicationNumber : IRequest<AnnualStrategicGoalsLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
