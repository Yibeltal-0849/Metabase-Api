using Application.BSC.Quiries.AnnualStrategicGoals.GetAnnualStrategicGoalsLoadAll; 
using MediatR;

namespace XOKA.Application.Finance.Quiries.AnnualStrategicGoals.GetAnnualStrategicGoalsLoadByPrimaryKeyStrategicThemeID
{
    public class GetAnnualStrategicGoalsLoadByPrimaryKeyStrategicThemeID: IRequest<AnnualStrategicGoalsLoadAllListVm>
    {
        public string Strategic_ThemeID { get; set; }
    }
}
