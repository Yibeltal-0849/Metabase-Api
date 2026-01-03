using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.Perspectives.PerspectivesInsert.PerspectivesInsertCommand
{ 
	 
      public class PerspectivesInsertHandler : IRequestHandler<PerspectivesInsertCommand, IList<_Perspectives_Perspective_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PerspectivesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<_Perspectives_Perspective_ID>> Handle( PerspectivesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<_Perspectives_Perspective_ID> result = await _procedureAdabter
                .Execute<_Perspectives_Perspective_ID>("[BSC].PerspectivesInsert", request);
           
            return result;
        }
    }
}
 
