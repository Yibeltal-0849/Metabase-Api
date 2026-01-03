using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procLCustomerLedgerEntries.GetprocLCustomerLedgerEntriesLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procLCustomerLedgerEntries.GetprocLCustomerLedgerEntriesByPrimaryKey
{
    public class GetprocLCustomerLedgerEntriesQueryHandler : IRequestHandler<GetprocLCustomerLedgerEntriesByPrimaryKey, GetprocLCustomerLedgerEntriesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLCustomerLedgerEntriesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLCustomerLedgerEntriesLoadAllListVm> Handle(GetprocLCustomerLedgerEntriesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<LCustomerLedgerEntries> procLCustomerLedgerEntriess = await _procedureAdabter
               .Execute<LCustomerLedgerEntries>("[FINA].[proc_L_Customer_Ledger_EntriesLoadByPrimaryKey]", request);
            GetprocLCustomerLedgerEntriesLoadAllListVm vm = new GetprocLCustomerLedgerEntriesLoadAllListVm
            {
                procLCustomerLedgerEntriess = _mapper.Map<IList<LCustomerLedgerEntries>, IList<GetprocLCustomerLedgerEntriesLoadAllVm>>(procLCustomerLedgerEntriess)
            };

            return vm;
        }
    }
}
