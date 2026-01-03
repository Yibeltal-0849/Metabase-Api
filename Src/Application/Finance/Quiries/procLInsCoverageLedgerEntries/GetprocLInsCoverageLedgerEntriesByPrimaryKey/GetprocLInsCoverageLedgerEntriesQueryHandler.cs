using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procLInsCoverageLedgerEntries.GetprocLInsCoverageLedgerEntriesLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procLInsCoverageLedgerEntries.GetprocLInsCoverageLedgerEntriesByPrimaryKey
{
    public class GetprocLInsCoverageLedgerEntriesQueryHandler : IRequestHandler<GetprocLInsCoverageLedgerEntriesByPrimaryKey, GetprocLInsCoverageLedgerEntriesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLInsCoverageLedgerEntriesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLInsCoverageLedgerEntriesLoadAllListVm> Handle(GetprocLInsCoverageLedgerEntriesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<L_Ins_Coverage_Ledger_Entries> procLInsCoverageLedgerEntriess = await _procedureAdabter
               .Execute<L_Ins_Coverage_Ledger_Entries>("[FINA].[proc_L_Ins_Coverage_Ledger_EntriesLoadByPrimaryKey]", request);
            GetprocLInsCoverageLedgerEntriesLoadAllListVm vm = new GetprocLInsCoverageLedgerEntriesLoadAllListVm
            {
                procLInsCoverageLedgerEntriess = _mapper.Map<IList<L_Ins_Coverage_Ledger_Entries>, IList<GetprocLInsCoverageLedgerEntriesLoadAllVm>>(procLInsCoverageLedgerEntriess)
            };

            return vm;
        }
    }
}
