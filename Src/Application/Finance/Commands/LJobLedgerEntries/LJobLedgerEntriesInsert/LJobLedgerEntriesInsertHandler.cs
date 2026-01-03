



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.LJobLedgerEntries.LJobLedgerEntriesInsert.LJobLedgerEntriesInsertCommand
{

    /// @author  Shimels Alem  L_Job_Ledger_EntriesInsert stored procedure.


    public class LJobLedgerEntriesInsertHandler : IRequestHandler<LJobLedgerEntriesInsertCommand, IList<LJobLedgerEntries_PostingDate>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LJobLedgerEntriesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LJobLedgerEntries_PostingDate>> Handle( LJobLedgerEntriesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<LJobLedgerEntries_PostingDate> result = await _procedureAdabter
                .Execute<LJobLedgerEntries_PostingDate>("[FINA].L_Job_Ledger_EntriesInsert", request);
           

            return result;
        }
    }
}
 