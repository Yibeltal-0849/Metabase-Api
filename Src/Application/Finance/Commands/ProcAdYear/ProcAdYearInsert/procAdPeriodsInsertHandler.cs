using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.ProcAdYearInsert.ProcAdYearInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_PeriodsInsert stored procedure.
	 
	 
      public class ProcAdYearInsertHandler : IRequestHandler<ProcAdYearInsertCommand, IList<ProcAdYearId>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ProcAdYearInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ProcAdYearId>> Handle( ProcAdYearInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ProcAdYearId> result = await _procedureAdabter
                .Execute<ProcAdYearId>("[FINA].[proc_Ad_YearInsert]", request);
           

            return result;
        }
    }
}
 
