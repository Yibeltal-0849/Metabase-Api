using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace Application.BSC.Commands.AnnualStrategicGoalsDetailsGroupByPerspective.AnnualStrategicGoalsDetailsGroupByPerspectiveDelete.AnnualStrategicGoalsDetailsGroupByPerspectiveDeleteCommand
{

    /// @author  Shimels Alem  Annual_Strategic_Goals_Details_GroupBy_PerspectiveDelete stored procedure.


    public class AnnualStrategicGoalsDetailsGroupByPerspectiveDeleteHandler : IRequestHandler<AnnualStrategicGoalsDetailsGroupByPerspectiveDeleteCommand, IList<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public AnnualStrategicGoalsDetailsGroupByPerspectiveDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID>> Handle( AnnualStrategicGoalsDetailsGroupByPerspectiveDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID> result = await _procedureAdabter
                .Execute<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID>("[BSC].Annual_Strategic_Goals_Details_GroupBy_PerspectiveDelete", request);
           
            return result;
        }
    }
}
  