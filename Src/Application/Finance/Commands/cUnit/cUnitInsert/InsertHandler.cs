



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cUnit.cUnitInsert.cUnitInsertCommand
{

    /// @author  Shimels Alem  c_UnitInsert stored procedure.


    public class cUnitInsertHandler : IRequestHandler<cUnitInsertCommand, IList<CUnit_Unit>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cUnitInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CUnit_Unit>> Handle( cUnitInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CUnit_Unit> result = await _procedureAdabter
                .Execute<CUnit_Unit>("[FINA].c_UnitInsert", request);
           

            return result;
        }
    }
}
 