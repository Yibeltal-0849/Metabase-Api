 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.procAccountPropose.GetprocAccountProposeLoadAll;

namespace Application.Finance.Quiries.procAccountPropose.GetprocAccountProposeLoadByPrimaryKey
{ 
	 
	#region procAccountProposeLoadByPrimaryKey  
    
    
    
      public class GetprocAccountProposeLoadByPrimaryKeyQueryHandler : IRequestHandler<GetprocAccountProposeLoadByPrimaryKey, GetprocAccountProposeLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocAccountProposeLoadByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAccountProposeLoadAllListVM> Handle(GetprocAccountProposeLoadByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<AccountPropose> procAccountProposeLoadByPrimaryKeys = await _procedureAdabter
               .Execute<AccountPropose>("[FINA].proc_Account_ProposeLoadByPrimaryKey", request);
            GetprocAccountProposeLoadAllListVM vm = new GetprocAccountProposeLoadAllListVM
            {
                 procAccountProposeLoadAlls = _mapper.Map<IList<AccountPropose>, IList<GetprocAccountProposeLoadAllVM>>(procAccountProposeLoadByPrimaryKeys)
            };

            return vm;
        }
         #endregion
    }
    
    
    
		
	  
	
		
	
    
}

