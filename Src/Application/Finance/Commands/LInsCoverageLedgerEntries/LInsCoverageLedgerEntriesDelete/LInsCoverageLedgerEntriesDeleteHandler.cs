using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.LInsCoverageLedgerEntries.LInsCoverageLedgerEntriesDelete.LInsCoverageLedgerEntriesDeleteCommand
{

    /// @author  Shimels Alem  L_Ins_Coverage_Ledger_EntriesDelete stored procedure.


    public class LInsCoverageLedgerEntriesDeleteHandler : IRequestHandler<LInsCoverageLedgerEntriesDeleteCommand, IList<L_Ins_Coverage_Ledger_Entries_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LInsCoverageLedgerEntriesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<L_Ins_Coverage_Ledger_Entries_Branch_ID>> Handle( LInsCoverageLedgerEntriesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<L_Ins_Coverage_Ledger_Entries_Branch_ID> result = await _procedureAdabter
                .Execute<L_Ins_Coverage_Ledger_Entries_Branch_ID>("[FINA].L_Ins_Coverage_Ledger_EntriesDelete", request);
           

            return result;
        }
    }
}
  