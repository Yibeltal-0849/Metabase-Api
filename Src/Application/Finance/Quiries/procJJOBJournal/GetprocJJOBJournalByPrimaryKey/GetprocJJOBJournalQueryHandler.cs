using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procJJOBJournal.GetprocJJOBJournalLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJJOBJournal.GetprocJJOBJournalByPrimaryKey
{
    public class GetprocJJOBJournalQueryHandler : IRequestHandler<GetprocJJOBJournalByPrimaryKey, GetprocJJOBJournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJJOBJournalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJJOBJournalLoadAllListVm> Handle(GetprocJJOBJournalByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JJobJournal> procJJOBJournals = await _procedureAdabter
               .Execute<JJobJournal>("[FINA].[proc_J_JOB_JournalLoadByPrimaryKey]", request);
            GetprocJJOBJournalLoadAllListVm vm = new GetprocJJOBJournalLoadAllListVm
            {
                procJJOBJournals = _mapper.Map<IList<JJobJournal>, IList<GetprocJJOBJournalLoadAllVm>>(procJJOBJournals)
            };

            return vm;
        }
    }
}
