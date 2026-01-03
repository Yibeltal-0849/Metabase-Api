using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.SSalesReturnOrder.SSalesReturnOrderDelete.SSalesReturnOrderDeleteCommand
{

    /// @author  Shimels Alem  S_Sales_Return_OrderDelete stored procedure.


    public class SSalesReturnOrderDeleteHandler : IRequestHandler<SSalesReturnOrderDeleteCommand, IList<SSalesReturnOrder_Sales_Return_Order_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SSalesReturnOrderDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SSalesReturnOrder_Sales_Return_Order_Line>> Handle( SSalesReturnOrderDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<SSalesReturnOrder_Sales_Return_Order_Line> result = await _procedureAdabter
                .Execute<SSalesReturnOrder_Sales_Return_Order_Line>("[FINA].S_Sales_Return_OrderDelete", request);
           

            return result;
        }
    }
}
  