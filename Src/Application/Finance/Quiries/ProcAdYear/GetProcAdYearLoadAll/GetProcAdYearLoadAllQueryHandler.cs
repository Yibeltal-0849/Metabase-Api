

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.ProcAdYear.GetProcAdYearLoadAll
{ 
	 
	#region ProcAdYearLoadAll  
      public class GetProcAdYearLoadAllQueryHandler : IRequestHandler<GetProcAdYearLoadAllQuery, GetProcAdYearLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetProcAdYearLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetProcAdYearLoadAllListVM> Handle(GetProcAdYearLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<AdYear> ProcAdYearLoadAlls = await _procedureAdabter
               .Execute<AdYear>("[FINA].[proc_Ad_YearLoadAll]");
            GetProcAdYearLoadAllListVM vm = new GetProcAdYearLoadAllListVM
            {
                ProcAdYearLoadAlls = _mapper.Map<IList<AdYear>, IList<GetProcAdYearLoadAllVM>>(ProcAdYearLoadAlls)
            };

            return vm;
        }
    }

        #endregion
		
	  
	
		
	
    
}

