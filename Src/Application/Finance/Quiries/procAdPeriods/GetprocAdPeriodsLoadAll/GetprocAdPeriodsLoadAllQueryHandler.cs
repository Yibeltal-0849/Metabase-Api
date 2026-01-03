

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
      public class GetprocAdPeriodsLoadAllQueryHandler : IRequestHandler<GetprocAdPeriodsLoadAllQuery, GetprocAdPeriodsLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocAdPeriodsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAdPeriodsLoadAllListVM> Handle(GetprocAdPeriodsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<AdPeriods> procAdPeriodsLoadAlls = await _procedureAdabter
               .Execute<AdPeriods>("[FINA].proc_Ad_PeriodsLoadAll");
            GetprocAdPeriodsLoadAllListVM vm = new GetprocAdPeriodsLoadAllListVM
            {
                procAdPeriodsLoadAlls = _mapper.Map<IList<AdPeriods>, IList<GetprocAdPeriodsLoadAllVM>>(procAdPeriodsLoadAlls)
            };

            return vm;
        }
    }

        #endregion
		
	  
	
		
	
    
}

