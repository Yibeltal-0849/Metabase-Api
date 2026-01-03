using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.StrategicInnitiative.StrategicInnitiativeDelete.StrategicInnitiativeDeleteCommand
{ 	 
	 
      public class StrategicInnitiativeDeleteHandler : IRequestHandler<StrategicInnitiativeDeleteCommand, IList<Strategic_Innitiative_Innitiative_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public StrategicInnitiativeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Strategic_Innitiative_Innitiative_ID>> Handle( StrategicInnitiativeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<Strategic_Innitiative_Innitiative_ID> result = await _procedureAdabter
                .Execute<Strategic_Innitiative_Innitiative_ID>("[BSC].Strategic_InnitiativeDelete", request);
           
            return result;
        }
    }
}
 
