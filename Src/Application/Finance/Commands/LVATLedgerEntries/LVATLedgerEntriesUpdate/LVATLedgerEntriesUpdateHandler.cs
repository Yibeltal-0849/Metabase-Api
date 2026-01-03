

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.LVATLedgerEntries.LVATLedgerEntriesUpdate.LVATLedgerEntriesUpdateCommand
{

    /// @author  Shimels Alem  L_VAT_Ledger_ EntriesUpdate stored procedure.


    public class LVATLedgerEntriesUpdateHandler : IRequestHandler<LVATLedgerEntriesUpdateCommand, IList<LVatLedgerEntries_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LVATLedgerEntriesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LVatLedgerEntries_Branch_ID>> Handle( LVATLedgerEntriesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<LVatLedgerEntries_Branch_ID> result = await _procedureAdabter
                .Execute<LVatLedgerEntries_Branch_ID>("[FINA].L_VAT_Ledger_ EntriesUpdate", request);
           

            return result;
        }
    }
}
 