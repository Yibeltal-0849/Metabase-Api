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

namespace Application.Finance.Quiries.procLBankAccountLedgerEntries.GetprocLBankAccountLedgerEntriesByPrimaryKey
{
    public class GetprocLBankAccountLedgerEntriesQueryHandler : IRequestHandler<GetprocLBankAccountLedgerEntriesByPrimaryKey, GetprocLBankAccountLedgerEntriesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLBankAccountLedgerEntriesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLBankAccountLedgerEntriesLoadAllListVm> Handle(GetprocLBankAccountLedgerEntriesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<LBankAccountLedgerEntries> procLBankAccountLedgerEntriess = await _procedureAdabter
               .Execute<LBankAccountLedgerEntries>("[FINA].[proc_L_Bank Account_Ledger_EntriesLoadByPrimaryKey]", request);
            GetprocLBankAccountLedgerEntriesLoadAllListVm vm = new GetprocLBankAccountLedgerEntriesLoadAllListVm
            {
                procLBankAccountLedgerEntriess = _mapper.Map<IList<LBankAccountLedgerEntries>, IList<GetprocLBankAccountLedgerEntriesLoadAllVm>>(procLBankAccountLedgerEntriess)
            };

            return vm;
        }
    }
}
