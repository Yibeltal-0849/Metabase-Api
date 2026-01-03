using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procLCustomerLedgerEntries.GetprocLCustomerLedgerEntriesLoadAll
{
    class GetprocLCustomerLedgerEntriesLoadAllQueryHandler : IRequestHandler<GetprocLCustomerLedgerEntriesLoadAllQuery, GetprocLCustomerLedgerEntriesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocLCustomerLedgerEntriesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLCustomerLedgerEntriesLoadAllListVm> Handle(GetprocLCustomerLedgerEntriesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<LCustomerLedgerEntries> procLCustomerLedgerEntriess = await _procedureAdabter
               .Execute<LCustomerLedgerEntries>("[FINA].[proc_L_Customer_Ledger_EntriesLoadAll]");
            GetprocLCustomerLedgerEntriesLoadAllListVm vm = new GetprocLCustomerLedgerEntriesLoadAllListVm
            {
                procLCustomerLedgerEntriess = _mapper.Map<IList<LCustomerLedgerEntries>, IList<GetprocLCustomerLedgerEntriesLoadAllVm>>(procLCustomerLedgerEntriess)
            };

            return vm;
        }
    }
}
