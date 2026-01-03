

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.SSalseqoute.SSalseqouteUpdate.SSalseqouteUpdateCommand
{

    /// @author  Shimels Alem  S_Salse_qouteUpdate stored procedure.


    public class SSalseqouteUpdateHandler : IRequestHandler<SSalseqouteUpdateCommand, IList<SSalseQoute_Sales_Qoute_Line_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SSalseqouteUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SSalseQoute_Sales_Qoute_Line_ID>> Handle( SSalseqouteUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<SSalseQoute_Sales_Qoute_Line_ID> result = await _procedureAdabter
                .Execute<SSalseQoute_Sales_Qoute_Line_ID>("[FINA].S_Salse_qouteUpdate", request);
           

            return result;
        }
    }
}
 