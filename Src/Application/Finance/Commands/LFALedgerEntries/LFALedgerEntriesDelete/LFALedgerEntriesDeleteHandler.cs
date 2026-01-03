using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.LFALedgerEntries.LFALedgerEntriesDelete.LFALedgerEntriesDeleteCommand
{

    /// @author  Shimels Alem  L_FA_Ledger_EntriesDelete stored procedure.


    public class LFALedgerEntriesDeleteHandler : IRequestHandler<LFALedgerEntriesDeleteCommand, IList<L_FA_Ledger_Entries_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LFALedgerEntriesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<L_FA_Ledger_Entries_Branch_ID>> Handle( LFALedgerEntriesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<L_FA_Ledger_Entries_Branch_ID> result = await _procedureAdabter
                .Execute<L_FA_Ledger_Entries_Branch_ID>("[FINA].L_FA_Ledger_EntriesDelete", request);
           

            return result;
        }
    }
}
  