using AutoMapper;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Quiries.CEmplye_Benefits.GetCEmplyeBenefitsLoadAll
{
    public class GetCEmplyeBenefitsLoadAllQueryHandler : MediatR.IRequestHandler<GetCEmplyeBenefitsLoadAllQuery, GetCEmplyeBenefitsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetCEmplyeBenefitsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCEmplyeBenefitsLoadAllListVm> Handle(GetCEmplyeBenefitsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_c_Emplye_Benefits> emplyeBenefits = await _procedureAdabter
               .Execute<Proc_c_Emplye_Benefits>("[HRA].[proc_c_Emplye_BenefitsLoadAll]");
            GetCEmplyeBenefitsLoadAllListVm vm = new GetCEmplyeBenefitsLoadAllListVm
            {
                EmplyeBenefits = _mapper.Map<IList<Proc_c_Emplye_Benefits>, IList<GetCEmplyeBenefitsLoadAllVm>>(emplyeBenefits)
            };

            return vm;
        }
    }
}
