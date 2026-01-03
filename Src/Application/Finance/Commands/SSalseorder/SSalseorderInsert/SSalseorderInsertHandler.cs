



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.SSalseorder.SSalseorderInsert.SSalseorderInsertCommand
{

    /// @author  Shimels Alem  S_Salse_orderInsert stored procedure.


    public class SSalseorderInsertHandler : IRequestHandler<SSalseorderInsertCommand, IList<SSalseOrder_Sales_Order_Line_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SSalseorderInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SSalseOrder_Sales_Order_Line_ID>> Handle( SSalseorderInsertCommand request, CancellationToken cancellationToken)
        {

            IList<SSalseOrder_Sales_Order_Line_ID> result = await _procedureAdabter
                .Execute<SSalseOrder_Sales_Order_Line_ID>("[FINA].S_Salse_orderInsert", request);
           

            return result;
        }
    }
}
 