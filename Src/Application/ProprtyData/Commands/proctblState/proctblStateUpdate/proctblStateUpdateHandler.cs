

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblState.proctblStateUpdate.proctblStateUpdateCommand
{

    /// @author  Shimels Alem  proc_tblStateUpdate stored procedure.


    public class proctblStateUpdateHandler : IRequestHandler<proctblStateUpdateCommand, IList<tblState_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblStateUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblState_id>> Handle( proctblStateUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblState_id> result = await _procedureAdabter
                .Execute<tblState_id>("[ProprtyData].proc_tblStateUpdate", request);
           

            return result;
        }
    }
}
 