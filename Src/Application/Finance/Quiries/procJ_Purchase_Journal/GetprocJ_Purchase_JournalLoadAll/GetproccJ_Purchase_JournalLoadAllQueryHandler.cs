using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccJ_Purchase_Journal.GetproccJ_Purchase_JournalLoadAll
{
    class GetproccJ_Purchase_JournalLoadAllQueryHandler : IRequestHandler<GetproccJ_Purchase_JournalLoadAllQuery, GetproccJ_Purchase_JournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccJ_Purchase_JournalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccJ_Purchase_JournalLoadAllListVm> Handle(GetproccJ_Purchase_JournalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JPurchaseJournal> proccJ_Purchase_Journals = await _procedureAdabter
               .Execute<JPurchaseJournal>("[FINA].[proc_c_CA_Beginning_BalanceLoadAll]");
            GetproccJ_Purchase_JournalLoadAllListVm vm = new GetproccJ_Purchase_JournalLoadAllListVm
            {
                proccJ_Purchase_Journals = _mapper.Map<IList<JPurchaseJournal>, IList<GetproccJ_Purchase_JournalLoadAllVm>>(proccJ_Purchase_Journals)
            };

            return vm;
        }
    }
}
