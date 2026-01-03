

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procAdPeriods.GetprocAdPeriodsLoadAll
{ 
	 
	#region procAdPeriodsLoadAll  
      public class GetprocAdPeriodsLoadAllforhrQueryHandler : IRequestHandler<GetprocAdPeriodsLoadAllforhrQuery, GetprocAdPeriodsLoadAllforHrListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocAdPeriodsLoadAllforhrQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAdPeriodsLoadAllforHrListVM> Handle(GetprocAdPeriodsLoadAllforhrQuery request, CancellationToken cancellationToken)
        {
            IList<AdPeriods> procAdPeriodsLoadAlls = await _procedureAdabter
               .Execute<AdPeriods>("[FINA].[proc_Ad_PeriodsLoad_For_HR]");
            GetprocAdPeriodsLoadAllforHrListVM vm = new GetprocAdPeriodsLoadAllforHrListVM
            {
                procAdPeriodsLoadAlls = _mapper.Map<IList<AdPeriods>, IList<GetprocAdPeriodsLoadAllVM>>(procAdPeriodsLoadAlls)
            };

            return vm;
        }
    }

        #endregion
		
	  
	
		
	
    
}

