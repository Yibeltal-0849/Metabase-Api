using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procLInsCoverageLedgerEntries.GetprocLInsCoverageLedgerEntriesLoadAll
{
    class GetprocLInsCoverageLedgerEntriesLoadAllQueryHandler : IRequestHandler<GetprocLInsCoverageLedgerEntriesLoadAllQuery, GetprocLInsCoverageLedgerEntriesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocLInsCoverageLedgerEntriesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLInsCoverageLedgerEntriesLoadAllListVm> Handle(GetprocLInsCoverageLedgerEntriesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<L_Ins_Coverage_Ledger_Entries> procLInsCoverageLedgerEntriess = await _procedureAdabter
               .Execute<L_Ins_Coverage_Ledger_Entries>("[FINA].[proc_L_Ins_Coverage_Ledger_EntriesLoadAll]");
            GetprocLInsCoverageLedgerEntriesLoadAllListVm vm = new GetprocLInsCoverageLedgerEntriesLoadAllListVm
            {
                procLInsCoverageLedgerEntriess = _mapper.Map<IList<L_Ins_Coverage_Ledger_Entries>, IList<GetprocLInsCoverageLedgerEntriesLoadAllVm>>(procLInsCoverageLedgerEntriess)
            };

            return vm;
        }
    }
}
