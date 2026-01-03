using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAnnualStrategicGoalsDetailsDelete.procAnnualStrategicGoalsDetailsDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Annual_Strategic_Goals_DetailsDelete stored procedure.
	 
	 
      public class procAnnualStrategicGoalsDetailsDeleteHandler : IRequestHandler<procAnnualStrategicGoalsDetailsDeleteCommand, IList<proc_AnnualStrategicGoalsDetails_ASGD_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAnnualStrategicGoalsDetailsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<proc_AnnualStrategicGoalsDetails_ASGD_ID>> Handle( procAnnualStrategicGoalsDetailsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<proc_AnnualStrategicGoalsDetails_ASGD_ID> result = await _procedureAdabter
                .Execute<proc_AnnualStrategicGoalsDetails_ASGD_ID>("[FINA].proc_Annual_Strategic_Goals_DetailsDelete", request);
           

            return result;
        }
    }
}
 
