using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.PPurchasecreditmemo.PPurchasecreditmemoDelete.PPurchasecreditmemoDeleteCommand
{

    /// @author  Shimels Alem  [P_Purchase credit memoDelete] stored procedure.


    public class PPurchasecreditmemoDeleteHandler : IRequestHandler<PPurchasecreditmemoDeleteCommand, IList<PPurchaseCreditMemo_Purchase_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PPurchasecreditmemoDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PPurchaseCreditMemo_Purchase_Line>> Handle( PPurchasecreditmemoDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<PPurchaseCreditMemo_Purchase_Line> result = await _procedureAdabter
                .Execute<PPurchaseCreditMemo_Purchase_Line>("[FINA].[P_Purchase credit memoDelete]", request);
           

            return result;
        }
    }
}
  