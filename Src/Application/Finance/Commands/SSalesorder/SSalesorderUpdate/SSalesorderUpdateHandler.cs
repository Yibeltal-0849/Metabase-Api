

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.SSalesorder.SSalesorderUpdate.SSalesorderUpdateCommand
{

    /// @author  Shimels Alem  S_Sales_orderUpdate stored procedure.


    public class SSalesorderUpdateHandler : IRequestHandler<SSalesorderUpdateCommand, IList<SSalesOrder_Sales_Order_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SSalesorderUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SSalesOrder_Sales_Order_Line>> Handle( SSalesorderUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<SSalesOrder_Sales_Order_Line> result = await _procedureAdabter
                .Execute<SSalesOrder_Sales_Order_Line>("[FINA].S_Sales_orderUpdate", request);
           

            return result;
        }
    }
}
 