using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJCashReceiptJournal.GetprocJCashReceiptJournalLoadAll
{
    class GetprocJCashReceiptJournalLoadAllQueryHandler : IRequestHandler<GetprocJCashReceiptJournalLoadAllQuery, GetprocJCashReceiptJournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJCashReceiptJournalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJCashReceiptJournalLoadAllListVm> Handle(GetprocJCashReceiptJournalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JCashReceiptJournal> procJCashReceiptJournals = await _procedureAdabter
               .Execute<JCashReceiptJournal>("[FINA].[proc_J_Cash_Receipt_JournalLoadAll]");
            GetprocJCashReceiptJournalLoadAllListVm vm = new GetprocJCashReceiptJournalLoadAllListVm
            {
                procJCashReceiptJournals = _mapper.Map<IList<JCashReceiptJournal>, IList<GetprocJCashReceiptJournalLoadAllVm>>(procJCashReceiptJournals)
            };

            return vm;
        }
    }
}
