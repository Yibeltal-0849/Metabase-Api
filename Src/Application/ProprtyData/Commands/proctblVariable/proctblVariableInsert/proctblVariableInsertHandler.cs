



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblVariable.proctblVariableInsert.proctblVariableInsertCommand
{

    /// @author  Shimels Alem  proc_tblVariableInsert stored procedure.


    public class proctblVariableInsertHandler : IRequestHandler<proctblVariableInsertCommand, IList<tblVariable_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblVariableInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblVariable_id>> Handle( proctblVariableInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblVariable_id> result = await _procedureAdabter
                .Execute<tblVariable_id>("[ProprtyData].proc_tblVariableInsert", request);
           

            return result;
        }
    }
}
 