using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procJGeneraljournal.GetprocJGeneraljournalLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJGeneraljournal.GetprocJGeneraljournalByPrimaryKey
{
    public class GetprocJGeneraljournalQueryHandler : IRequestHandler<GetprocJGeneraljournalByPrimaryKey, GetprocJGeneraljournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJGeneraljournalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJGeneraljournalLoadAllListVm> Handle(GetprocJGeneraljournalByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JGeneralJournal> procJGeneraljournals = await _procedureAdabter
               .Execute<JGeneralJournal>("[FINA].[proc_J_General_journalLoadByPrimaryKey]", request);
            GetprocJGeneraljournalLoadAllListVm vm = new GetprocJGeneraljournalLoadAllListVm
            {
                procJGeneraljournals = _mapper.Map<IList<JGeneralJournal>, IList<GetprocJGeneraljournalLoadAllVm>>(procJGeneraljournals)
            };

            return vm;
        }
    }
}
