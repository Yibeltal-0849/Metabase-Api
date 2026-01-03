using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdPeriodsInsert.procAdPeriodsInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_PeriodsInsert stored procedure.
	 
	 
      public class procAdPeriodsInsertHandler : IRequestHandler<procAdPeriodsInsertCommand, IList<AdPeriods_StartDate>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAdPeriodsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AdPeriods_StartDate>> Handle( procAdPeriodsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<AdPeriods_StartDate> result = await _procedureAdabter
                .Execute<AdPeriods_StartDate>("[FINA].proc_Ad_PeriodsInsert", request);
           

            return result;
        }
    }
}
 
