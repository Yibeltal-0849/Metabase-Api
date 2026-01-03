

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cCostMethod.cCostMethodUpdate.cCostMethodUpdateCommand
{

    /// @author  Shimels Alem  c_Cost_MethodUpdate stored procedure.


    public class cCostMethodUpdateHandler : IRequestHandler<cCostMethodUpdateCommand, IList<CCostMethod_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cCostMethodUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CCostMethod_ID>> Handle( cCostMethodUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CCostMethod_ID> result = await _procedureAdabter
                .Execute<CCostMethod_ID>("[FINA].c_Cost_MethodUpdate", request);
           

            return result;
        }
    }
}
 