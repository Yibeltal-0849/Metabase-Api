

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.LJobLedgerEntries.LJobLedgerEntriesUpdate.LJobLedgerEntriesUpdateCommand
{

    /// @author  Shimels Alem  L_Job_Ledger_EntriesUpdate stored procedure.


    public class LJobLedgerEntriesUpdateHandler : IRequestHandler<LJobLedgerEntriesUpdateCommand, IList<LJobLedgerEntries_PostingDate>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LJobLedgerEntriesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LJobLedgerEntries_PostingDate>> Handle( LJobLedgerEntriesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<LJobLedgerEntries_PostingDate> result = await _procedureAdabter
                .Execute<LJobLedgerEntries_PostingDate>("[FINA].L_Job_Ledger_EntriesUpdate", request);
           

            return result;
        }
    }
}
 