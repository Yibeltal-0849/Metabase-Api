using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccTurmsAndCredit.GetproccTurmsAndCreditLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccTurmsAndCredit.GetproccTurmsAndCreditByPrimaryKey
{
    public class GetproccTurmsAndCreditQueryHandler : IRequestHandler<GetproccTurmsAndCreditByPrimaryKey, GetproccTurmsAndCreditLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccTurmsAndCreditQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccTurmsAndCreditLoadAllListVm> Handle(GetproccTurmsAndCreditByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CTurmsAndCredit> proccTurmsAndCredits = await _procedureAdabter
               .Execute<CTurmsAndCredit>("[FINA].[proc_c_TurmsAndCreditLoadByPrimaryKey]", request);
            GetproccTurmsAndCreditLoadAllListVm vm = new GetproccTurmsAndCreditLoadAllListVm
            {
                proccTurmsAndCredits = _mapper.Map<IList<CTurmsAndCredit>, IList<GetproccTurmsAndCreditLoadAllVm>>(proccTurmsAndCredits)
            };

            return vm;
        }
    }
}
