using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJPaymentJournal.GetprocJPaymentJournalLoadAll
{
    class GetprocJPaymentJournalLoadAllQueryHandler : IRequestHandler<GetprocJPaymentJournalLoadAllQuery, GetprocJPaymentJournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJPaymentJournalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJPaymentJournalLoadAllListVm> Handle(GetprocJPaymentJournalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JPaymentJournal> procJPaymentJournals = await _procedureAdabter
               .Execute<JPaymentJournal>("[FINA].[proc_J_Payment_JournalLoadAll]");
            GetprocJPaymentJournalLoadAllListVm vm = new GetprocJPaymentJournalLoadAllListVm
            {
                procJPaymentJournals = _mapper.Map<IList<JPaymentJournal>, IList<GetprocJPaymentJournalLoadAllVm>>(procJPaymentJournals)
            };

            return vm;
        }
    }
}
