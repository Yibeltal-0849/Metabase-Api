using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccEmplyeBenefits.GetproccEmplyeBenefitsLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccEmplyeBenefits.GetproccEmplyeBenefitsByPrimaryKey
{
    public class GetproccEmplyeBenefitsQueryHandler : IRequestHandler<GetproccEmplyeBenefitsByPrimaryKey, GetproccEmplyeBenefitsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccEmplyeBenefitsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccEmplyeBenefitsLoadAllListVm> Handle(GetproccEmplyeBenefitsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CEmplyeBenefits> proccEmplyeBenefitss = await _procedureAdabter
               .Execute<CEmplyeBenefits>("[FINA].[proc_c_Emplye_BenefitsLoadByPrimaryKey]", request);
            GetproccEmplyeBenefitsLoadAllListVm vm = new GetproccEmplyeBenefitsLoadAllListVm
            {
                proccEmplyeBenefitss = _mapper.Map<IList<CEmplyeBenefits>, IList<GetproccEmplyeBenefitsLoadAllVm>>(proccEmplyeBenefitss)
            };

            return vm;
        }
    }
}
