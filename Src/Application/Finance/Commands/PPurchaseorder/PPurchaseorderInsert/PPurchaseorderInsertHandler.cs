



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.PPurchaseorder.PPurchaseorderInsert.PPurchaseorderInsertCommand
{

    /// @author  Shimels Alem  [P_Purchase orderInsert] stored procedure.


    public class PPurchaseorderInsertHandler : IRequestHandler<PPurchaseorderInsertCommand, IList<PPurchaseOrder_Purchase_Line_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PPurchaseorderInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PPurchaseOrder_Purchase_Line_ID>> Handle( PPurchaseorderInsertCommand request, CancellationToken cancellationToken)
        {

            IList<PPurchaseOrder_Purchase_Line_ID> result = await _procedureAdabter
                .Execute<PPurchaseOrder_Purchase_Line_ID>("[FINA].[P_Purchase orderInsert]", request);
           

            return result;
        }
    }
}
 