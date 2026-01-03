using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procLFALedgerEntries.GetprocLFALedgerEntriesLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procLFALedgerEntries.GetprocLFALedgerEntriesByPrimaryKey
{
    public class GetprocLFALedgerEntriesQueryHandler : IRequestHandler<GetprocLFALedgerEntriesByPrimaryKey, GetprocLFALedgerEntriesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLFALedgerEntriesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLFALedgerEntriesLoadAllListVm> Handle(GetprocLFALedgerEntriesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<L_FA_Ledger_Entries> procLFALedgerEntriess = await _procedureAdabter
               .Execute<L_FA_Ledger_Entries>("[FINA].[proc_L_FA_Ledger_EntriesLoadByPrimaryKey]", request);
            GetprocLFALedgerEntriesLoadAllListVm vm = new GetprocLFALedgerEntriesLoadAllListVm
            {
                procLFALedgerEntriess = _mapper.Map<IList<L_FA_Ledger_Entries>, IList<GetprocLFALedgerEntriesLoadAllVm>>(procLFALedgerEntriess)
            };

            return vm;
        }
    }
}
