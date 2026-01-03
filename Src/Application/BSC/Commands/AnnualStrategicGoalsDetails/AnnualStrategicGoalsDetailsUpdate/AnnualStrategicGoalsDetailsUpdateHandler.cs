

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;



namespace Application.BSC.Commands.AnnualStrategicGoalsDetails.AnnualStrategicGoalsDetailsUpdate.AnnualStrategicGoalsDetailsUpdateCommand
{

    /// @author  Shimels Alem  Annual_Strategic_Goals_DetailsUpdate stored procedure.


    public class AnnualStrategicGoalsDetailsUpdateHandler : IRequestHandler<AnnualStrategicGoalsDetailsUpdateCommand, IList<AnnualStrategicGoalsDetails_ASGD_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public AnnualStrategicGoalsDetailsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AnnualStrategicGoalsDetails_ASGD_ID>> Handle( AnnualStrategicGoalsDetailsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<AnnualStrategicGoalsDetails_ASGD_ID> result = await _procedureAdabter
                .Execute<AnnualStrategicGoalsDetails_ASGD_ID>("[BSC].Annual_Strategic_Goals_DetailsUpdate", request);
           
            return result;
        }
    }
}
 