using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procLFALedgerEntries.GetprocLFALedgerEntriesLoadAll
{
    class GetprocLFALedgerEntriesLoadAllQueryHandler : IRequestHandler<GetprocLFALedgerEntriesLoadAllQuery, GetprocLFALedgerEntriesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocLFALedgerEntriesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLFALedgerEntriesLoadAllListVm> Handle(GetprocLFALedgerEntriesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<L_FA_Ledger_Entries> procLFALedgerEntriess = await _procedureAdabter
               .Execute<L_FA_Ledger_Entries>("[FINA].[proc_L_FA_Ledger_EntriesLoadAll]");
            GetprocLFALedgerEntriesLoadAllListVm vm = new GetprocLFALedgerEntriesLoadAllListVm
            {
                procLFALedgerEntriess = _mapper.Map<IList<L_FA_Ledger_Entries>, IList<GetprocLFALedgerEntriesLoadAllVm>>(procLFALedgerEntriess)
            };

            return vm;
        }
    }
}
