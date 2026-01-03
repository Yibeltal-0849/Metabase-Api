

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.LBankAccountLedgerEntries.LBankAccountLedgerEntriesUpdate.LBankAccountLedgerEntriesUpdateCommand
{

    /// @author  Shimels Alem  L_Bank Account_Ledger_EntriesUpdate stored procedure.


    public class LBankAccountLedgerEntriesUpdateHandler : IRequestHandler<LBankAccountLedgerEntriesUpdateCommand, IList<LBankAccountLedgerEntries_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LBankAccountLedgerEntriesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<LBankAccountLedgerEntries_Branch_ID>> Handle( LBankAccountLedgerEntriesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<LBankAccountLedgerEntries_Branch_ID> result = await _procedureAdabter
                .Execute<LBankAccountLedgerEntries_Branch_ID>("[FINA].L_Bank Account_Ledger_EntriesUpdate", request);
           

            return result;
        }
    }
}
 