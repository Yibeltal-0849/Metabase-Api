



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.LGeneralLedgerEntries.LGeneralLedgerEntriesInsert.LGeneralLedgerEntriesInsertCommand
{

    /// @author  Shimels Alem  LGeneralLedgerEntriesInsert stored procedure.


    public class LGeneralLedgerEntriesInsertHandler : IRequestHandler<LGeneralLedgerEntriesInsertCommand, IList<Proc_LGeneralLedgerEntries_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public LGeneralLedgerEntriesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_LGeneralLedgerEntries_Code>> Handle( LGeneralLedgerEntriesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Proc_LGeneralLedgerEntries_Code> result = await _procedureAdabter
                .Execute<Proc_LGeneralLedgerEntries_Code>("[FINA].proc_L_General_Ledger_EntriesInsert", request);
           

            return result;
        }
    }
}
 