

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblVariable.proctblVariableUpdate.proctblVariableUpdateCommand
{

    /// @author  Shimels Alem  proc_tblVariableUpdate stored procedure.


    public class proctblVariableUpdateHandler : IRequestHandler<proctblVariableUpdateCommand, IList<tblVariable_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblVariableUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblVariable_id>> Handle( proctblVariableUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblVariable_id> result = await _procedureAdabter
                .Execute<tblVariable_id>("[ProprtyData].proc_tblVariableUpdate", request);
           

            return result;
        }
    }
}
 