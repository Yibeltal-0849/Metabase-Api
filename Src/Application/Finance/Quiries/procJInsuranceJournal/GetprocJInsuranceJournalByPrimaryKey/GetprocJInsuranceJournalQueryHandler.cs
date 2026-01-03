using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procJInsuranceJournal.GetprocJInsuranceJournalLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procJInsuranceJournal.GetprocJInsuranceJournalByPrimaryKey
{
    public class GetprocJInsuranceJournalQueryHandler : IRequestHandler<GetprocJInsuranceJournalByPrimaryKey, GetprocJInsuranceJournalLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocJInsuranceJournalQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocJInsuranceJournalLoadAllListVm> Handle(GetprocJInsuranceJournalByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<JInsuranceJournal> procJInsuranceJournals = await _procedureAdabter
               .Execute<JInsuranceJournal>("[FINA].[proc_J_Insurance_JournalLoadByPrimaryKey]", request);
            GetprocJInsuranceJournalLoadAllListVm vm = new GetprocJInsuranceJournalLoadAllListVm
            {
                procJInsuranceJournals = _mapper.Map<IList<JInsuranceJournal>, IList<GetprocJInsuranceJournalLoadAllVm>>(procJInsuranceJournals)
            };

            return vm;
        }
    }
}
