

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procADOrg.GetprocADOrgLoadAll
{ 
	 
	#region procADOrgLoadAll  
      public class GetprocADOrgLoadAllQueryHandler : IRequestHandler<GetprocADOrgLoadAllQuery, GetprocADOrgLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocADOrgLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocADOrgLoadAllListVM> Handle(GetprocADOrgLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<AdOrg> procADOrgLoadAlls = await _procedureAdabter
               .Execute<AdOrg>("[FINA].proc_AD_OrgLoadAll");

            GetprocADOrgLoadAllListVM vm = new GetprocADOrgLoadAllListVM
            {
                procADOrgLoadAlls = _mapper.Map<IList<AdOrg>, IList<GetprocADOrgLoadAllVM>>(procADOrgLoadAlls)
            };

            return vm;
        }
    }
}
        #endregion
		
	  
	
	 