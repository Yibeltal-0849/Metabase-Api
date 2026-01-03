

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.SBlanketSalesorder.SBlanketSalesorderUpdate.SBlanketSalesorderUpdateCommand
{

    /// @author  Shimels Alem  [S_Blanket_Sales_orderUpdate] stored procedure.


    public class SBlanketSalesorderUpdateHandler : IRequestHandler<SBlanketSalesorderUpdateCommand, IList<SBlanketSalesOrder_Sales_Blanket_Order_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SBlanketSalesorderUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SBlanketSalesOrder_Sales_Blanket_Order_Line>> Handle( SBlanketSalesorderUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<SBlanketSalesOrder_Sales_Blanket_Order_Line> result = await _procedureAdabter
                .Execute<SBlanketSalesOrder_Sales_Blanket_Order_Line>("[FINA].[S_Blanket_Sales_orderUpdate]", request);
           

            return result;
        }
    }
}
 