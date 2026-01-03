using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccEmplyeBenefits.GetproccEmplyeBenefitsLoadAll
{
    class GetproccEmplyeBenefitsLoadAllQueryHandler : IRequestHandler<GetproccEmplyeBenefitsLoadAllQuery, GetproccEmplyeBenefitsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccEmplyeBenefitsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccEmplyeBenefitsLoadAllListVm> Handle(GetproccEmplyeBenefitsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CEmplyeBenefits> proccEmplyeBenefitss = await _procedureAdabter
               .Execute<CEmplyeBenefits>("[FINA].[proc_c_Emplye_BenefitsLoadAll]");
            GetproccEmplyeBenefitsLoadAllListVm vm = new GetproccEmplyeBenefitsLoadAllListVm
            {
                proccEmplyeBenefitss = _mapper.Map<IList<CEmplyeBenefits>, IList<GetproccEmplyeBenefitsLoadAllVm>>(proccEmplyeBenefitss)
            };

            return vm;
        }
    }
}
