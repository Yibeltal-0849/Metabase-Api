

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.LVendorLedgerEntries.LVendorLedgerEntriesUpdate.LVendorLedgerEntriesUpdateCommand
{

    /// @author  Shimels Alem  L_Vendor_Ledger_EntriesUpdate stored procedure.


    public class LVendorLedgerEntriesUpdateHandler : IRequestHandler<LVendorLedgerEntriesUpdateCommand, IList<L_Vendor_Ledger_Entries_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LVendorLedgerEntriesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<L_Vendor_Ledger_Entries_Branch_ID>> Handle( LVendorLedgerEntriesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<L_Vendor_Ledger_Entries_Branch_ID> result = await _procedureAdabter
                .Execute<L_Vendor_Ledger_Entries_Branch_ID>("[FINA].L_Vendor_Ledger_EntriesUpdate", request);
           

            return result;
        }
    }
}
 