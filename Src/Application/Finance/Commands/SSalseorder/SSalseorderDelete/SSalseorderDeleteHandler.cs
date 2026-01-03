using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.SSalseorder.SSalseorderDelete.SSalseorderDeleteCommand
{

    /// @author  Shimels Alem  S_Salse_orderDelete stored procedure.


    public class SSalseorderDeleteHandler : IRequestHandler<SSalseorderDeleteCommand, IList<SSalseOrder_Sales_Order_Line_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SSalseorderDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SSalseOrder_Sales_Order_Line_ID>> Handle( SSalseorderDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<SSalseOrder_Sales_Order_Line_ID> result = await _procedureAdabter
                .Execute<SSalseOrder_Sales_Order_Line_ID>("[FINA].S_Salse_orderDelete", request);
           

            return result;
        }
    }
}
  