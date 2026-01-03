using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccPayType.GetproccPayTypeLoadAll
{
    class GetproccPayTypeLoadAllQueryHandler : IRequestHandler<GetproccPayTypeLoadAllQuery, GetproccPayTypeLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccPayTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccPayTypeLoadAllListVm> Handle(GetproccPayTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CPayType> proccPayTypes = await _procedureAdabter
               .Execute<CPayType>("[FINA].[proc_c_PayTypeLoadAll]");
            GetproccPayTypeLoadAllListVm vm = new GetproccPayTypeLoadAllListVm
            {
                proccPayTypes = _mapper.Map<IList<CPayType>, IList<GetproccPayTypeLoadAllVm>>(proccPayTypes)
            };

            return vm;
        }
    }
}
