using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cUnit.cUnitDelete.cUnitDeleteCommand
{

    /// @author  Shimels Alem  c_UnitDelete stored procedure.


    public class cUnitDeleteHandler : IRequestHandler<cUnitDeleteCommand, IList<CUnit_Unit>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cUnitDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CUnit_Unit>> Handle( cUnitDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CUnit_Unit> result = await _procedureAdabter
                .Execute<CUnit_Unit>("[FINA].c_UnitDelete", request);
           

            return result;
        }
    }
}
  