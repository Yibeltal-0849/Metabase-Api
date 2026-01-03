using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procLVATLedgerEntries.GetprocLVATLedgerEntriesLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procLVATLedgerEntries.GetprocLVATLedgerEntriesByPrimaryKey
{
    public class GetprocLVATLedgerEntriesQueryHandler : IRequestHandler<GetprocLVATLedgerEntriesByPrimaryKey, GetprocLVATLedgerEntriesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLVATLedgerEntriesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLVATLedgerEntriesLoadAllListVm> Handle(GetprocLVATLedgerEntriesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<LVatLedgerEntries> procLVATLedgerEntriess = await _procedureAdabter
               .Execute<LVatLedgerEntries>("[FINA].[proc_L_VAT_Ledger_ EntriesLoadByPrimaryKey]", request);
            GetprocLVATLedgerEntriesLoadAllListVm vm = new GetprocLVATLedgerEntriesLoadAllListVm
            {
                procLVATLedgerEntriess = _mapper.Map<IList<LVatLedgerEntries>, IList<GetprocLVATLedgerEntriesLoadAllVm>>(procLVATLedgerEntriess)
            };

            return vm;
        }
    }
}
