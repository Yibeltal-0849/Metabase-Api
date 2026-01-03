using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJJOBJournal.GetprocJJOBJournalLoadAll
{
    class GetprocJJOBJournalLoadAllQueryHandler : IRequestHandler<GetprocJJOBJournalLoadAllQuery, GetprocJJOBJournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJJOBJournalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJJOBJournalLoadAllListVm> Handle(GetprocJJOBJournalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JJobJournal> procJJOBJournals = await _procedureAdabter
               .Execute<JJobJournal>("[FINA].[proc_J_JOB_JournalLoadAll]");
            GetprocJJOBJournalLoadAllListVm vm = new GetprocJJOBJournalLoadAllListVm
            {
                procJJOBJournals = _mapper.Map<IList<JJobJournal>, IList<GetprocJJOBJournalLoadAllVm>>(procJJOBJournals)
            };

            return vm;
        }
    }
}
