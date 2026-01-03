



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.SSalesReturnOrder.SSalesReturnOrderInsert.SSalesReturnOrderInsertCommand
{

    /// @author  Shimels Alem  S_Sales_Return_OrderInsert stored procedure.


    public class SSalesReturnOrderInsertHandler : IRequestHandler<SSalesReturnOrderInsertCommand, IList<SSalesReturnOrder_Sales_Return_Order_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SSalesReturnOrderInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SSalesReturnOrder_Sales_Return_Order_Line>> Handle( SSalesReturnOrderInsertCommand request, CancellationToken cancellationToken)
        {

            IList<SSalesReturnOrder_Sales_Return_Order_Line> result = await _procedureAdabter
                .Execute<SSalesReturnOrder_Sales_Return_Order_Line>("[FINA].S_Sales_Return_OrderInsert", request);
           

            return result;
        }
    }
}
 