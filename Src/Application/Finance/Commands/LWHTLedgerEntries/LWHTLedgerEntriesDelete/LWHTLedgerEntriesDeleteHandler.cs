using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.LWHTLedgerEntries.LWHTLedgerEntriesDelete.LWHTLedgerEntriesDeleteCommand
{

    /// @author  Shimels Alem  L_WHT_Ledger_EntriesDelete stored procedure.


    public class LWHTLedgerEntriesDeleteHandler : IRequestHandler<LWHTLedgerEntriesDeleteCommand, IList<L_WHT_Ledger_Entries_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LWHTLedgerEntriesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<L_WHT_Ledger_Entries_Branch_ID>> Handle( LWHTLedgerEntriesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<L_WHT_Ledger_Entries_Branch_ID> result = await _procedureAdabter
                .Execute<L_WHT_Ledger_Entries_Branch_ID>("[FINA].[L_WHT_Ledger_EntriesDelete]", request);
           

            return result;
        }
    }
}
  