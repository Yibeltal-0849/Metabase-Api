using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.Perspectives.PerspectivesUpdate.PerspectivesUpdateCommand
{ 

      public class PerspectivesUpdateHandler : IRequestHandler<PerspectivesUpdateCommand, IList<_Perspectives_Perspective_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PerspectivesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<_Perspectives_Perspective_ID>> Handle( PerspectivesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<_Perspectives_Perspective_ID> result = await _procedureAdabter
                .Execute<_Perspectives_Perspective_ID>("[BSC].PerspectivesUpdate", request);
           
            return result;
        }
    }
}
 
