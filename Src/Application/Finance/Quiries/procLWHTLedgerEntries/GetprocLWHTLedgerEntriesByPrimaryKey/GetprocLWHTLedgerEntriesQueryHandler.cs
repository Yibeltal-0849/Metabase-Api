using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procLWHTLedgerEntries.GetprocLWHTLedgerEntriesLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procLWHTLedgerEntries.GetprocLWHTLedgerEntriesByPrimaryKey
{
    public class GetprocLWHTLedgerEntriesQueryHandler : IRequestHandler<GetprocLWHTLedgerEntriesByPrimaryKey, GetprocLWHTLedgerEntriesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLWHTLedgerEntriesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLWHTLedgerEntriesLoadAllListVm> Handle(GetprocLWHTLedgerEntriesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<L_WHT_Ledger_Entries> procLWHTLedgerEntriess = await _procedureAdabter
               .Execute<L_WHT_Ledger_Entries>("[FINA].[proc_L_WHT_Ledger_EntriesLoadByPrimaryKey]", request);
            GetprocLWHTLedgerEntriesLoadAllListVm vm = new GetprocLWHTLedgerEntriesLoadAllListVm
            {
                procLWHTLedgerEntriess = _mapper.Map<IList<L_WHT_Ledger_Entries>, IList<GetprocLWHTLedgerEntriesLoadAllVm>>(procLWHTLedgerEntriess)
            };

            return vm;
        }
    }
}
