 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.procADOrg.GetprocADOrgLoadAll;
using Application.Finance.Quiries.procADOrg.GetADOrgLoadByPrimaryKey;

namespace Application.Finance.Quiries.procADOrg.GetADOrgLoadByPrimaryKey
{ 
	 
	#region procADOrgLoadByPrimaryKey  
    
    
    
      public class GetprocADOrgLoadByPrimaryKeyQueryHandler : IRequestHandler<GetprocADOrgLoadByPrimaryKey, GetprocADOrgLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocADOrgLoadByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocADOrgLoadAllListVM> Handle(GetprocADOrgLoadByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<AdOrg> procADOrgLoadByPrimaryKeys = await _procedureAdabter
               .Execute<AdOrg>("[FINA].proc_AD_OrgLoadByPrimaryKey", request);
            GetprocADOrgLoadAllListVM vm = new GetprocADOrgLoadAllListVM
            {
                procADOrgLoadAlls = _mapper.Map<IList<AdOrg>, IList<GetprocADOrgLoadAllVM>>(procADOrgLoadByPrimaryKeys)
            };

            return vm;
        }
         #endregion
    }	
    
}

