



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.LVendorLedgerEntries.LVendorLedgerEntriesInsert.LVendorLedgerEntriesInsertCommand
{

    /// @author  Shimels Alem  L_Vendor_Ledger_EntriesInsert stored procedure.


    public class LVendorLedgerEntriesInsertHandler : IRequestHandler<LVendorLedgerEntriesInsertCommand, IList<L_Vendor_Ledger_Entries_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LVendorLedgerEntriesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<L_Vendor_Ledger_Entries_Branch_ID>> Handle( LVendorLedgerEntriesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<L_Vendor_Ledger_Entries_Branch_ID> result = await _procedureAdabter
                .Execute<L_Vendor_Ledger_Entries_Branch_ID>("[FINA].L_Vendor_Ledger_EntriesInsert", request);
           

            return result;
        }
    }
}
 