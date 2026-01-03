



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.LFALedgerEntries.LFALedgerEntriesInsert.LFALedgerEntriesInsertCommand
{

    /// @author  Shimels Alem  L_FA_Ledger_EntriesInsert stored procedure.


    public class LFALedgerEntriesInsertHandler : IRequestHandler<LFALedgerEntriesInsertCommand, IList<L_FA_Ledger_Entries_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LFALedgerEntriesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<L_FA_Ledger_Entries_Branch_ID>> Handle( LFALedgerEntriesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<L_FA_Ledger_Entries_Branch_ID> result = await _procedureAdabter
                .Execute<L_FA_Ledger_Entries_Branch_ID>("[FINA].L_FA_Ledger_EntriesInsert", request);
           

            return result;
        }
    }
}
 