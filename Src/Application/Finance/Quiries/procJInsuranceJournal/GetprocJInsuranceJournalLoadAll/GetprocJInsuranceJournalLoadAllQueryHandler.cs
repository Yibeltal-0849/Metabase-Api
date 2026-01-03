using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJInsuranceJournal.GetprocJInsuranceJournalLoadAll
{
    class GetprocJInsuranceJournalLoadAllQueryHandler : IRequestHandler<GetprocJInsuranceJournalLoadAllQuery, GetprocJInsuranceJournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocJInsuranceJournalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJInsuranceJournalLoadAllListVm> Handle(GetprocJInsuranceJournalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JInsuranceJournal> procJInsuranceJournals = await _procedureAdabter
               .Execute<JInsuranceJournal>("[FINA].[proc_J_Insurance_JournalLoadAll]");
            GetprocJInsuranceJournalLoadAllListVm vm = new GetprocJInsuranceJournalLoadAllListVm
            {
                procJInsuranceJournals = _mapper.Map<IList<JInsuranceJournal>, IList<GetprocJInsuranceJournalLoadAllVm>>(procJInsuranceJournals)
            };

            return vm;
        }
    }
}
