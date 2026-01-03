



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;


namespace Application.Budget.Commands.AnnualStrategicGoalsDetailsGroupByPerspective.AnnualStrategicGoalsDetailsGroupByPerspectiveInsert.AnnualStrategicGoalsDetailsGroupByPerspectiveInsertCommand
{

    /// @author  Shimels Alem  Annual_Strategic_Goals_Details_GroupBy_PerspectiveInsert stored procedure.


    public class AnnualStrategicGoalsDetailsGroupByPerspectiveInsertHandler : IRequestHandler<AnnualStrategicGoalsDetailsGroupByPerspectiveInsertCommand, IList<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public AnnualStrategicGoalsDetailsGroupByPerspectiveInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID>> Handle( AnnualStrategicGoalsDetailsGroupByPerspectiveInsertCommand request, CancellationToken cancellationToken)
        {

            IList<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID> result = await _procedureAdabter
                .Execute<AnnualStrategicGoalsDetailsGroupByPerspective_ASGDGP_ID>("[Budget].Annual_Strategic_Goals_Details_GroupBy_PerspectiveInsert", request);
           

            return result;
        }
    }
}
 