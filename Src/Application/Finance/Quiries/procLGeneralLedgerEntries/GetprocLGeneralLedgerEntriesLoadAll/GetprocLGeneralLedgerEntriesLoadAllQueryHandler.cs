using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procLGeneralLedgerEntries.GetprocLGeneralLedgerEntriesLoadAll
{
    class GetprocLGeneralLedgerEntriesLoadAllQueryHandler : IRequestHandler<GetprocLGeneralLedgerEntriesLoadAllQuery, GetprocLGeneralLedgerEntriesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocLGeneralLedgerEntriesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLGeneralLedgerEntriesLoadAllListVm> Handle(GetprocLGeneralLedgerEntriesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<LGeneralLedgerEntries> procLGeneralLedgerEntriess = await _procedureAdabter
               .Execute<LGeneralLedgerEntries>("[FINA].proc_L_General_Ledger_EntriesLoadAll");
            GetprocLGeneralLedgerEntriesLoadAllListVm vm = new GetprocLGeneralLedgerEntriesLoadAllListVm
            {
                procLGeneralLedgerEntriess = _mapper.Map<IList<LGeneralLedgerEntries>, IList<GetprocLGeneralLedgerEntriesLoadAllVm>>(procLGeneralLedgerEntriess)
            };

            return vm;
        }
    }
}
