



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.CReceiveMoney.CReceiveMoneyInsert.CReceiveMoneyInsertCommand
{

    /// @author  Shimels Alem  C_Receive_MoneyInsert stored procedure.


    public class CReceiveMoneyInsertHandler : IRequestHandler<CReceiveMoneyInsertCommand, IList<CReceiveMoney_Receipt_Number>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CReceiveMoneyInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CReceiveMoney_Receipt_Number>> Handle( CReceiveMoneyInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CReceiveMoney_Receipt_Number> result = await _procedureAdabter
                .Execute<CReceiveMoney_Receipt_Number>("[FINA].C_Receive_MoneyInsert", request);
           

            return result;
        }
    }
}
 