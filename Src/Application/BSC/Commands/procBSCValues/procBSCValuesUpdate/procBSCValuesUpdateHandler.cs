

using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;



namespace Application.BSC.Commands.procBSCValues.procBSCValuesUpdate.procBSCValuesUpdateCommand
{

    /// @author  Shimels Alem  proc_BSC_ValuesUpdate stored procedure.


    public class procBSCValuesUpdateHandler : IRequestHandler<procBSCValuesUpdateCommand, IList<BSCValues_BSCValueID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBSCValuesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BSCValues_BSCValueID>> Handle( procBSCValuesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<BSCValues_BSCValueID> result = await _procedureAdabter
                .Execute<BSCValues_BSCValueID>("[BSC].proc_BSC_ValuesUpdate", request);
           

            return result;
        }
    }
}
 