using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJSalesJournal.GetprocJSalesJournalLoadAll
{
    class GetprocJSalesJournalLoadAllQueryHandler : IRequestHandler<GetprocJSalesJournalLoadAllQuery, GetprocJSalesJournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJSalesJournalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJSalesJournalLoadAllListVm> Handle(GetprocJSalesJournalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JSalesJournal> procJSalesJournals = await _procedureAdabter
               .Execute<JSalesJournal>("[FINA].[proc_J_Sales_JournalLoadAll]");
            GetprocJSalesJournalLoadAllListVm vm = new GetprocJSalesJournalLoadAllListVm
            {
                procJSalesJournals = _mapper.Map<IList<JSalesJournal>, IList<GetprocJSalesJournalLoadAllVm>>(procJSalesJournals)
            };

            return vm;
        }
    }
}
