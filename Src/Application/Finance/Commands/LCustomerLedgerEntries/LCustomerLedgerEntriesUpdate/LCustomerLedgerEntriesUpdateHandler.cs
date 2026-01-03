

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.LCustomerLedgerEntries.LCustomerLedgerEntriesUpdate.LCustomerLedgerEntriesUpdateCommand
{

    /// @author  Shimels Alem  L_Customer_Ledger_EntriesUpdate stored procedure.


    public class LCustomerLedgerEntriesUpdateHandler : IRequestHandler<LCustomerLedgerEntriesUpdateCommand, IList<LCustomerLedgerEntries_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LCustomerLedgerEntriesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LCustomerLedgerEntries_Branch_ID>> Handle( LCustomerLedgerEntriesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<LCustomerLedgerEntries_Branch_ID> result = await _procedureAdabter
                .Execute<LCustomerLedgerEntries_Branch_ID>("[FINA].L_Customer_Ledger_EntriesUpdate", request);
           

            return result;
        }
    }
}
 