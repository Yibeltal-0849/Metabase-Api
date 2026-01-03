



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cCostMethod.cCostMethodInsert.cCostMethodInsertCommand
{

    /// @author  Shimels Alem  c_Cost_MethodInsert stored procedure.


    public class cCostMethodInsertHandler : IRequestHandler<cCostMethodInsertCommand, IList<CCostMethod_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cCostMethodInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CCostMethod_ID>> Handle( cCostMethodInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CCostMethod_ID> result = await _procedureAdabter
                .Execute<CCostMethod_ID>("[FINA].c_Cost_MethodInsert", request);
           

            return result;
        }
    }
}
 