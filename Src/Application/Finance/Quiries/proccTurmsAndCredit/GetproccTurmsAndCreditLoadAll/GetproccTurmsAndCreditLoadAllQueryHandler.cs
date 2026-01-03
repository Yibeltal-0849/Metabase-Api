using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccTurmsAndCredit.GetproccTurmsAndCreditLoadAll
{
    class GetproccTurmsAndCreditLoadAllQueryHandler : IRequestHandler<GetproccTurmsAndCreditLoadAllQuery, GetproccTurmsAndCreditLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccTurmsAndCreditLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccTurmsAndCreditLoadAllListVm> Handle(GetproccTurmsAndCreditLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CTurmsAndCredit> proccTurmsAndCredits = await _procedureAdabter
               .Execute<CTurmsAndCredit>("[FINA].[proc_c_TurmsAndCreditLoadAll]");
            GetproccTurmsAndCreditLoadAllListVm vm = new GetproccTurmsAndCreditLoadAllListVm
            {
                proccTurmsAndCredits = _mapper.Map<IList<CTurmsAndCredit>, IList<GetproccTurmsAndCreditLoadAllVm>>(proccTurmsAndCredits)
            };

            return vm;
        }
    }
}
