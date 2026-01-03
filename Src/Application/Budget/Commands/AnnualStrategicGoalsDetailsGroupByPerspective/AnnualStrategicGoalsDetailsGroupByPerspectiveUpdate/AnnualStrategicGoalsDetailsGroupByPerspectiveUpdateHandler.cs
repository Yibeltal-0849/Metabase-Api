

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;



namespace Application.Budget.Commands.AnnualStrategicGoalsDetailsGroupByPerspective.AnnualStrategicGoalsDetailsGroupByPerspectiveUpdate.AnnualStrategicGoalsDetailsGroupByPerspectiveUpdateCommand
{

    /// @author  Shimels Alem  Annual_Strategic_Goals_Details_GroupBy_PerspectiveUpdate stored procedure.


    public class AnnualStrategicGoalsDetailsGroupByPerspectiveUpdateHandler : IRequestHandler<AnnualStrategicGoalsDetailsGroupByPerspectiveUpdateCommand, IList<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public AnnualStrategicGoalsDetailsGroupByPerspectiveUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID>> Handle( AnnualStrategicGoalsDetailsGroupByPerspectiveUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID> result = await _procedureAdabter
                .Execute<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID>("[Budget].Annual_Strategic_Goals_Details_GroupBy_PerspectiveUpdate", request);
           

            return result;
        }
    }
}
 