using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.SSalseqoute.SSalseqouteDelete.SSalseqouteDeleteCommand
{

    /// @author  Shimels Alem  S_Salse_qouteDelete stored procedure.


    public class SSalseqouteDeleteHandler : IRequestHandler<SSalseqouteDeleteCommand, IList<SSalseQoute_Sales_Qoute_Line_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public SSalseqouteDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<SSalseQoute_Sales_Qoute_Line_ID>> Handle( SSalseqouteDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<SSalseQoute_Sales_Qoute_Line_ID> result = await _procedureAdabter
                .Execute<SSalseQoute_Sales_Qoute_Line_ID>("[FINA].S_Salse_qouteDelete", request);
           

            return result;
        }
    }
}
  