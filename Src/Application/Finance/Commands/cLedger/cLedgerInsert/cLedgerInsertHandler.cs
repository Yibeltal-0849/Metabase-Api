



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cLedger.cLedgerInsert.cLedgerInsertCommand
{

    /// @author  Shimels Alem  c_LedgerInsert stored procedure.


    public class cLedgerInsertHandler : IRequestHandler<cLedgerInsertCommand, IList<CLedger_Period_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cLedgerInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CLedger_Period_ID>> Handle( cLedgerInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CLedger_Period_ID> result = await _procedureAdabter
                .Execute<CLedger_Period_ID>("[FINA].c_LedgerInsert", request);
           

            return result;
        }
    }
}
 