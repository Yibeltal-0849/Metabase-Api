

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Commands.procJobPositions.procJobPositionsUpdate.procJobPositionsUpdateCommand
{ 
	 
	/// @author  Shimels Alem  proc_Job_PositionsUpdate stored procedure.
	 
	 
      public class procJobPositionsUpdateHandler : IRequestHandler<procJobPositionsUpdateCommand, IList<JobPositions_PosID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procJobPositionsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JobPositions_PosID>> Handle( procJobPositionsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<JobPositions_PosID> result = await _procedureAdabter
                .Execute<JobPositions_PosID>("[HRA].proc_Job_PositionsUpdate", request);
           

            return result;
        }
    }
}
 