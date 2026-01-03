using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdPeriodsUpdate.procAdPeriodsUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_PeriodsUpdate stored procedure.
	 
	 
      public class procAdPeriodsUpdateHandler : IRequestHandler<procAdPeriodsUpdateCommand, IList<AdPeriods_StartDate>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAdPeriodsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AdPeriods_StartDate>> Handle( procAdPeriodsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<AdPeriods_StartDate> result = await _procedureAdabter
                .Execute<AdPeriods_StartDate>("[FINA].[proc_Ad_PeriodsUpdate]", request);
           

            return result;
        }
    }
}
 
