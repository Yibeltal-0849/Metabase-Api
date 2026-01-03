using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procJItemJournal.GetprocJItemJournalLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJItemJournal.GetprocJItemJournalByPrimaryKey
{
    public class GetprocJItemJournalQueryHandler : IRequestHandler<GetprocJItemJournalByPrimaryKey, GetprocJItemJournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJItemJournalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJItemJournalLoadAllListVm> Handle(GetprocJItemJournalByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JItemJournal> procJItemJournals = await _procedureAdabter
               .Execute<JItemJournal>("[FINA].[proc_J_Item_JournalLoadByPrimaryKey]", request);
            GetprocJItemJournalLoadAllListVm vm = new GetprocJItemJournalLoadAllListVm
            {
                procJItemJournals = _mapper.Map<IList<JItemJournal>, IList<GetprocJItemJournalLoadAllVm>>(procJItemJournals)
            };

            return vm;
        }
    }
}
