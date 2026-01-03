using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procLGeneralLedgerEntries.GetprocLGeneralLedgerEntriesLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procLGeneralLedgerEntries.GetprocLGeneralLedgerEntriesByPrimaryKey
{
    public class GetprocLGeneralLedgerEntriesQueryHandler : IRequestHandler<GetprocLGeneralLedgerEntriesByPrimaryKey, GetprocLGeneralLedgerEntriesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLGeneralLedgerEntriesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLGeneralLedgerEntriesLoadAllListVm> Handle(GetprocLGeneralLedgerEntriesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<LGeneralLedgerEntries> procLGeneralLedgerEntriess = await _procedureAdabter
               .Execute<LGeneralLedgerEntries>("[FINA].[proc_L_General_Ledger_EntriesLoadByPrimaryKey]", request);
            GetprocLGeneralLedgerEntriesLoadAllListVm vm = new GetprocLGeneralLedgerEntriesLoadAllListVm
            {
                procLGeneralLedgerEntriess = _mapper.Map<IList<LGeneralLedgerEntries>, IList<GetprocLGeneralLedgerEntriesLoadAllVm>>(procLGeneralLedgerEntriess)
            };

            return vm;
        }
    }
}
