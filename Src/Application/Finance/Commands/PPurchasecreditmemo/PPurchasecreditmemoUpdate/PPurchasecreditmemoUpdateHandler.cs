

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.PPurchasecreditmemo.PPurchasecreditmemoUpdate.PPurchasecreditmemoUpdateCommand
{

    /// @author  Shimels Alem  [P_Purchase credit memoUpdate] stored procedure.


    public class PPurchasecreditmemoUpdateHandler : IRequestHandler<PPurchasecreditmemoUpdateCommand, IList<PPurchaseCreditMemo_Purchase_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PPurchasecreditmemoUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PPurchaseCreditMemo_Purchase_Line>> Handle( PPurchasecreditmemoUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<PPurchaseCreditMemo_Purchase_Line> result = await _procedureAdabter
                .Execute<PPurchaseCreditMemo_Purchase_Line>("[FINA].[P_Purchase credit memoUpdate]", request);
           

            return result;
        }
    }
}
 