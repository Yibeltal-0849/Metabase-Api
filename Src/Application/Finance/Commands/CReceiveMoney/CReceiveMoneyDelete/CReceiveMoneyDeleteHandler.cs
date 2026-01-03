using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CReceiveMoney.CReceiveMoneyDelete.CReceiveMoneyDeleteCommand
{

    /// @author  Shimels Alem  C_Receive_MoneyDelete stored procedure.


    public class CReceiveMoneyDeleteHandler : IRequestHandler<CReceiveMoneyDeleteCommand, IList<CReceiveMoney_Receipt_Number>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CReceiveMoneyDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CReceiveMoney_Receipt_Number>> Handle( CReceiveMoneyDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CReceiveMoney_Receipt_Number> result = await _procedureAdabter
                .Execute<CReceiveMoney_Receipt_Number>("[FINA].C_Receive_MoneyDelete", request);
           

            return result;
        }
    }
}
  