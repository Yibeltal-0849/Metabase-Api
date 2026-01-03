



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.PPurchasequote.PPurchasequoteInsert.PPurchasequoteInsertCommand
{

    /// @author  Shimels Alem  [P_Purchase quoteInsert] stored procedure.


    public class PPurchasequoteInsertHandler : IRequestHandler<PPurchasequoteInsertCommand, IList<PPurchaseQuote_Purchase_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PPurchasequoteInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PPurchaseQuote_Purchase_Line>> Handle( PPurchasequoteInsertCommand request, CancellationToken cancellationToken)
        {

            IList<PPurchaseQuote_Purchase_Line> result = await _procedureAdabter
                .Execute<PPurchaseQuote_Purchase_Line>("[FINA].[P_Purchase quoteInsert]", request);
  
            return result;
        }
    }
}
 