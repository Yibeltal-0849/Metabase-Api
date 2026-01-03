



using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;


namespace Application.HRA.Commands.procJobPositions.procJobPositionsInsert.procJobPositionsInsertCommand
{ 
	 
	/// @author  Shimels Alem  proc_Job_PositionsInsert stored procedure.
	 
	 
      public class procJobPositionsInsertHandler : IRequestHandler<procJobPositionsInsertCommand, IList<JobPositions_PosID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procJobPositionsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JobPositions_PosID>> Handle( procJobPositionsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<JobPositions_PosID> result = await _procedureAdabter
                .Execute<JobPositions_PosID>("[HRA].[Job_PositionsInsert]", request);
           

            return result;
        }
    }
}
 