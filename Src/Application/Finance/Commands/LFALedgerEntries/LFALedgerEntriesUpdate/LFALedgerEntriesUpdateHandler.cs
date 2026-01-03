

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.LFALedgerEntries.LFALedgerEntriesUpdate.LFALedgerEntriesUpdateCommand
{

    /// @author  Shimels Alem  L_FA_Ledger_EntriesUpdate stored procedure.


    public class LFALedgerEntriesUpdateHandler : IRequestHandler<LFALedgerEntriesUpdateCommand, IList<L_FA_Ledger_Entries_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LFALedgerEntriesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<L_FA_Ledger_Entries_Branch_ID>> Handle( LFALedgerEntriesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<L_FA_Ledger_Entries_Branch_ID> result = await _procedureAdabter
                .Execute<L_FA_Ledger_Entries_Branch_ID>("[FINA].L_FA_Ledger_EntriesUpdate", request);
           

            return result;
        }
    }
}
 