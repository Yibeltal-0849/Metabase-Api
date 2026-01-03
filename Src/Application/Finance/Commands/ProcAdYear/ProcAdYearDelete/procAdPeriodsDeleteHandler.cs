using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.ProcAdYearDelete.ProcAdYearDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_PeriodsDelete stored procedure.
	 
	 
      public class ProcAdYearDeleteHandler : IRequestHandler<ProcAdYearDeleteCommand, IList<ProcAdYearId>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ProcAdYearDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ProcAdYearId>> Handle( ProcAdYearDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ProcAdYearId> result = await _procedureAdabter
                .Execute<ProcAdYearId>("[FINA].[proc_Ad_YearDelete]", request);
           

            return result;
        }
    }
}
 
