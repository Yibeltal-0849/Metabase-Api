using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procJPaymentJournal.GetprocJPaymentJournalLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJPaymentJournal.GetprocJPaymentJournalByPrimaryKey
{
    public class GetprocJPaymentJournalQueryHandler : IRequestHandler<GetprocJPaymentJournalByPrimaryKey, GetprocJPaymentJournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJPaymentJournalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJPaymentJournalLoadAllListVm> Handle(GetprocJPaymentJournalByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JPaymentJournal> procJPaymentJournals = await _procedureAdabter
               .Execute<JPaymentJournal>("[FINA].[proc_J_Payment_JournalLoadByPrimaryKey]", request);
            GetprocJPaymentJournalLoadAllListVm vm = new GetprocJPaymentJournalLoadAllListVm
            {
                procJPaymentJournals = _mapper.Map<IList<JPaymentJournal>, IList<GetprocJPaymentJournalLoadAllVm>>(procJPaymentJournals)
            };

            return vm;
        }
    }
}
