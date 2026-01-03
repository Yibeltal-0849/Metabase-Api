using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procLBankAccountLedgerEntries.GetprocLBankAccountLedgerEntriesLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procLBankAccountLedgerEntries.GetprocLBankAccountLedgerEntriesByForBankRecon
{
    public class GetprocLBankAccountLedgerEntriesForBankReconQueryHandler : IRequestHandler<GetprocLBankAccountLedgerEntriesByForBankRecon, GetprocLBankAccountLedgerEntriesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLBankAccountLedgerEntriesForBankReconQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLBankAccountLedgerEntriesLoadAllListVm> Handle(GetprocLBankAccountLedgerEntriesByForBankRecon request, CancellationToken cancellationToken)
        {
           
            IList<LBankAccountLedgerEntries> procLBankAccountLedgerEntriess = await _procedureAdabter
               .Execute<LBankAccountLedgerEntries>("[FINA].[proc_L_Bank Account_Ledger_EntriesLoadByForBankRecon]", request);
            GetprocLBankAccountLedgerEntriesLoadAllListVm vm = new GetprocLBankAccountLedgerEntriesLoadAllListVm
            {
                procLBankAccountLedgerEntriess = _mapper.Map<IList<LBankAccountLedgerEntries>, IList<GetprocLBankAccountLedgerEntriesLoadAllVm>>(procLBankAccountLedgerEntriess)
            };

            return vm;
        }
    }
}
