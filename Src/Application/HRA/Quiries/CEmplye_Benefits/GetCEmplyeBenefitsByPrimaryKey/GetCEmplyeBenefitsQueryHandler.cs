using XOKA.Application.HRA.Quiries.CEmplye_Benefits;
using XOKA.Application.HRA.Quiries.CEmplye_Benefits.GetCEmplyeBenefitsLoadAll;
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.CEmplye_Benefits.GetCEmplyeBenefitsByPrimaryKey
{
    public class GetCEmplyeBenefitsQueryHandler : IRequestHandler<GetCEmplyeBenefitsByPrimaryKey, GetCEmplyeBenefitsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetCEmplyeBenefitsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCEmplyeBenefitsLoadAllListVm> Handle(GetCEmplyeBenefitsByPrimaryKey request, CancellationToken cancellationToken)
        {
            string name = request.Name;
            IList<Proc_c_Emplye_Benefits> EmplyeBenefitss = await _procedureAdabter
               .Execute<Proc_c_Emplye_Benefits>("[HRA].[proc_c_Emplye_BenefitsLoadByPrimaryKey]", (nameof(name), name));
            GetCEmplyeBenefitsLoadAllListVm vm = new GetCEmplyeBenefitsLoadAllListVm
            {
                EmplyeBenefits = _mapper.Map<IList<Proc_c_Emplye_Benefits>, IList<GetCEmplyeBenefitsLoadAllVm>>(EmplyeBenefitss)
            };

            return vm;
        }
    }
}
