using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.PPurchasereturnorder.PPurchasereturnorderDelete.PPurchasereturnorderDeleteCommand
{

    /// @author  Shimels Alem  [P_Purchase return orderDelete] stored procedure.


    public class PPurchasereturnorderDeleteHandler : IRequestHandler<PPurchasereturnorderDeleteCommand, IList<PPurchaseReturnOrder_Purchase_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PPurchasereturnorderDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PPurchaseReturnOrder_Purchase_Line>> Handle( PPurchasereturnorderDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<PPurchaseReturnOrder_Purchase_Line> result = await _procedureAdabter
                .Execute<PPurchaseReturnOrder_Purchase_Line>("[FINA].[P_Purchase return orderDelete]", request);
           

            return result;
        }
    }
}
  