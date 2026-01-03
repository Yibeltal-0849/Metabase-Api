using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJPurchaseJournal.GetprocJPurchaseJournalLoadAll
{
    class GetprocJPurchaseJournalLoadAllQueryHandler : IRequestHandler<GetprocJPurchaseJournalLoadAllQuery, GetprocJPurchaseJournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJPurchaseJournalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJPurchaseJournalLoadAllListVm> Handle(GetprocJPurchaseJournalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JPurchaseJournal> procJPurchaseJournals = await _procedureAdabter
               .Execute<JPurchaseJournal>("[FINA].[proc_J_Purchase_JournalLoadAll]");
            GetprocJPurchaseJournalLoadAllListVm vm = new GetprocJPurchaseJournalLoadAllListVm
            {
                procJPurchaseJournals = _mapper.Map<IList<JPurchaseJournal>, IList<GetprocJPurchaseJournalLoadAllVm>>(procJPurchaseJournals)
            };

            return vm;
        }
    }
}
