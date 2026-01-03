using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJGeneraljournal.GetprocJGeneraljournalLoadAll
{
    class GetprocJGeneraljournalLoadAllQueryHandler : IRequestHandler<GetprocJGeneraljournalLoadAllQuery, GetprocJGeneraljournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJGeneraljournalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJGeneraljournalLoadAllListVm> Handle(GetprocJGeneraljournalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JGeneralJournal> procJGeneraljournals = await _procedureAdabter
               .Execute<JGeneralJournal>("[FINA].[proc_J_General_journalLoadAll]");
            GetprocJGeneraljournalLoadAllListVm vm = new GetprocJGeneraljournalLoadAllListVm
            {
                procJGeneraljournals = _mapper.Map<IList<JGeneralJournal>, IList<GetprocJGeneraljournalLoadAllVm>>(procJGeneraljournals)
            };

            return vm;
        }
    }
}
