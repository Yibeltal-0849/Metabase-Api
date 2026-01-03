



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.SSalseqoute.SSalseqouteInsert.SSalseqouteInsertCommand
{

    /// @author  Shimels Alem  S_Salse_qouteInsert stored procedure.


    public class SSalseqouteInsertHandler : IRequestHandler<SSalseqouteInsertCommand, IList<SSalseQoute_Sales_Qoute_Line_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SSalseqouteInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SSalseQoute_Sales_Qoute_Line_ID>> Handle( SSalseqouteInsertCommand request, CancellationToken cancellationToken)
        {

            IList<SSalseQoute_Sales_Qoute_Line_ID> result = await _procedureAdabter
                .Execute<SSalseQoute_Sales_Qoute_Line_ID>("[FINA].S_Salse_qouteInsert", request);
           

            return result;
        }
    }
}
 