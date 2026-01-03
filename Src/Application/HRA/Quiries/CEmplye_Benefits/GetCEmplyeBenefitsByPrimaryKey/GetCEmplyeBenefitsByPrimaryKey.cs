using XOKA.Application.HRA.Quiries.CEmplye_Benefits.GetCEmplyeBenefitsLoadAll;
using MediatR;

namespace XOKA.Application.HRA.Quiries.CEmplye_Benefits.GetCEmplyeBenefitsByPrimaryKey
{
    /// @author  Shimels Alem  GetCEmplyeBenefitsByPrimaryKey stored procedure.
    
    public class GetCEmplyeBenefitsByPrimaryKey : IRequest<GetCEmplyeBenefitsLoadAllListVm>
    {
        public string Name { get; set; }
    }
}
