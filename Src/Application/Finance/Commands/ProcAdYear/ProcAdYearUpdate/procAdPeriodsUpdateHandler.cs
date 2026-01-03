using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.ProcAdYearUpdate.ProcAdYearUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_PeriodsUpdate stored procedure.
	 
	 
      public class ProcAdYearUpdateHandler : IRequestHandler<ProcAdYearUpdateCommand, IList<ProcAdYearId>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ProcAdYearUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ProcAdYearId>> Handle( ProcAdYearUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ProcAdYearId> result = await _procedureAdabter
                .Execute<ProcAdYearId>("[FINA].[proc_Ad_YearUpdate]", request);
           

            return result;
        }
    }
}
 
