



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.PPurchasereturnorder.PPurchasereturnorderInsert.PPurchasereturnorderInsertCommand
{

    /// @author  Shimels Alem  [P_Purchase return orderInsert] stored procedure.


    public class PPurchasereturnorderInsertHandler : IRequestHandler<PPurchasereturnorderInsertCommand, IList<PPurchaseReturnOrder_Purchase_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PPurchasereturnorderInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PPurchaseReturnOrder_Purchase_Line>> Handle( PPurchasereturnorderInsertCommand request, CancellationToken cancellationToken)
        {

            IList<PPurchaseReturnOrder_Purchase_Line> result = await _procedureAdabter
                .Execute<PPurchaseReturnOrder_Purchase_Line>("[FINA].[P_Purchase return orderInsert]", request);
           

            return result;
        }
    }
}
 