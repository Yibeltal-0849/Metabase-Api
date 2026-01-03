using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.procBSCValues.procBSCValuesDelete.procBSCValuesDeleteCommand
{

    /// @author  Shimels Alem  proc_BSC_ValuesDelete stored procedure.


    public class procBSCValuesDeleteHandler : IRequestHandler<procBSCValuesDeleteCommand, IList<BSCValues_BSCValueID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBSCValuesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BSCValues_BSCValueID>> Handle( procBSCValuesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<BSCValues_BSCValueID> result = await _procedureAdabter
                .Execute<BSCValues_BSCValueID>("[BSC].proc_BSC_ValuesDelete", request);
           

            return result;
        }
    }
}
  