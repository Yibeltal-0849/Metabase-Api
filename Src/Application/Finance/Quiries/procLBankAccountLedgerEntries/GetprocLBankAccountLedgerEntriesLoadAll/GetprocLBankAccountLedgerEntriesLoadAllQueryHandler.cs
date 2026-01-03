using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procLBankAccountLedgerEntries.GetprocLBankAccountLedgerEntriesLoadAll
{
    class GetprocLBankAccountLedgerEntriesLoadAllQueryHandler : IRequestHandler<GetprocLBankAccountLedgerEntriesLoadAllQuery, GetprocLBankAccountLedgerEntriesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocLBankAccountLedgerEntriesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLBankAccountLedgerEntriesLoadAllListVm> Handle(GetprocLBankAccountLedgerEntriesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<LBankAccountLedgerEntries> procLBankAccountLedgerEntriess = await _procedureAdabter
               .Execute<LBankAccountLedgerEntries>("[FINA].[proc_L_Bank Account_Ledger_EntriesLoadAll]");
            GetprocLBankAccountLedgerEntriesLoadAllListVm vm = new GetprocLBankAccountLedgerEntriesLoadAllListVm
            {
                procLBankAccountLedgerEntriess = _mapper.Map<IList<LBankAccountLedgerEntries>, IList<GetprocLBankAccountLedgerEntriesLoadAllVm>>(procLBankAccountLedgerEntriess)
            };

            return vm;
        }
    }
}
