using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procJCashReceiptJournal.GetprocJCashReceiptJournalLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJCashReceiptJournal.GetprocJCashReceiptJournalByPrimaryKey
{
    public class GetprocJCashReceiptJournalQueryHandler : IRequestHandler<GetprocJCashReceiptJournalByPrimaryKey, GetprocJCashReceiptJournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJCashReceiptJournalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJCashReceiptJournalLoadAllListVm> Handle(GetprocJCashReceiptJournalByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JCashReceiptJournal> procJCashReceiptJournals = await _procedureAdabter
               .Execute<JCashReceiptJournal>("[FINA].[proc_J_Cash_Receipt_JournalLoadByPrimaryKey]", request);
            GetprocJCashReceiptJournalLoadAllListVm vm = new GetprocJCashReceiptJournalLoadAllListVm
            {
                procJCashReceiptJournals = _mapper.Map<IList<JCashReceiptJournal>, IList<GetprocJCashReceiptJournalLoadAllVm>>(procJCashReceiptJournals)
            };

            return vm;
        }
    }
}
