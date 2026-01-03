

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.LInsCoverageLedgerEntries.LInsCoverageLedgerEntriesUpdate.LInsCoverageLedgerEntriesUpdateCommand
{

    /// @author  Shimels Alem  L_Ins_Coverage_Ledger_EntriesUpdate stored procedure.


    public class LInsCoverageLedgerEntriesUpdateHandler : IRequestHandler<LInsCoverageLedgerEntriesUpdateCommand, IList<L_Ins_Coverage_Ledger_Entries_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LInsCoverageLedgerEntriesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<L_Ins_Coverage_Ledger_Entries_Branch_ID>> Handle( LInsCoverageLedgerEntriesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<L_Ins_Coverage_Ledger_Entries_Branch_ID> result = await _procedureAdabter
                .Execute<L_Ins_Coverage_Ledger_Entries_Branch_ID>("[FINA].[L_Ins_Coverage_Ledger_EntriesUpdate]", request);
           

            return result;
        }
    }
}
 