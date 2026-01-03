using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procLVATLedgerEntries.GetprocLVATLedgerEntriesLoadAll
{
    class GetprocLVATLedgerEntriesLoadAllQueryHandler : IRequestHandler<GetprocLVATLedgerEntriesLoadAllQuery, GetprocLVATLedgerEntriesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocLVATLedgerEntriesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLVATLedgerEntriesLoadAllListVm> Handle(GetprocLVATLedgerEntriesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<LVatLedgerEntries> procLVATLedgerEntriess = await _procedureAdabter
               .Execute<LVatLedgerEntries>("[FINA].[proc_L_VAT_Ledger_ EntriesLoadAll]");
            GetprocLVATLedgerEntriesLoadAllListVm vm = new GetprocLVATLedgerEntriesLoadAllListVm
            {
                procLVATLedgerEntriess = _mapper.Map<IList<LVatLedgerEntries>, IList<GetprocLVATLedgerEntriesLoadAllVm>>(procLVATLedgerEntriess)
            };

            return vm;
        }
    }
}
