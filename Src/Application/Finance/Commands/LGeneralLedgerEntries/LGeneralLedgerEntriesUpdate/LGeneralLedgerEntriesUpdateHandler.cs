

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.LGeneralLedgerEntries.LGeneralLedgerEntriesUpdate.LGeneralLedgerEntriesUpdateCommand
{

    /// @author  Shimels Alem  LGeneralLedgerEntriesUpdate stored procedure.


    public class LGeneralLedgerEntriesUpdateHandler : IRequestHandler<LGeneralLedgerEntriesUpdateCommand, IList<Proc_LGeneralLedgerEntries_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LGeneralLedgerEntriesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_LGeneralLedgerEntries_Code>> Handle( LGeneralLedgerEntriesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Proc_LGeneralLedgerEntries_Code> result = await _procedureAdabter
                .Execute<Proc_LGeneralLedgerEntries_Code>("[FINA].proc_L_General_Ledger_EntriesUpdate", request);
           

            return result;
        }
    }
}
 