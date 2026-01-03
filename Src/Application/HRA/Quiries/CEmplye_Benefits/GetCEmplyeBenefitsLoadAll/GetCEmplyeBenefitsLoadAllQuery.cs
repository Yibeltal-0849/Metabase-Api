using MediatR;

namespace XOKA.Application.HRA.Quiries.CEmplye_Benefits.GetCEmplyeBenefitsLoadAll
{
    public class GetCEmplyeBenefitsLoadAllQuery : IRequest<GetCEmplyeBenefitsLoadAllListVm>
    {
        public string Name { get; set; }
    }
}
