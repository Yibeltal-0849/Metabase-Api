using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJItemJournal.GetprocJItemJournalLoadAll
{
    class GetprocJItemJournalLoadAllQueryHandler : IRequestHandler<GetprocJItemJournalLoadAllQuery, GetprocJItemJournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJItemJournalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJItemJournalLoadAllListVm> Handle(GetprocJItemJournalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JItemJournal> procJItemJournals = await _procedureAdabter
               .Execute<JItemJournal>("[FINA].[Jproc_J_Item_JournalLoadAll]");
            GetprocJItemJournalLoadAllListVm vm = new GetprocJItemJournalLoadAllListVm
            {
                procJItemJournals = _mapper.Map<IList<JItemJournal>, IList<GetprocJItemJournalLoadAllVm>>(procJItemJournals)
            };

            return vm;
        }
    }
}
