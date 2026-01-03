

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.PPurchasequote.PPurchasequoteUpdate.PPurchasequoteUpdateCommand
{

    /// @author  Shimels Alem  [P_Purchase quoteUpdate] stored procedure.


    public class PPurchasequoteUpdateHandler : IRequestHandler<PPurchasequoteUpdateCommand, IList<PPurchaseQuote_Purchase_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PPurchasequoteUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PPurchaseQuote_Purchase_Line>> Handle( PPurchasequoteUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<PPurchaseQuote_Purchase_Line> result = await _procedureAdabter
                .Execute<PPurchaseQuote_Purchase_Line>("[FINA].[P_Purchase quoteUpdate]", request);
           

            return result;
        }
    }
}
 