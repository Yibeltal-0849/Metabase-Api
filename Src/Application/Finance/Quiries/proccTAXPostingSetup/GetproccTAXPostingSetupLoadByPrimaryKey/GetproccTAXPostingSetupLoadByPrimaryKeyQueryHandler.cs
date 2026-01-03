 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.proccTAXPostingSetup.GetproccTAXPostingSetupLoadAll;
using Application.Finance.Quiries.proccTAXPostingSetup.GetTAXPostingSetupLoadByPrimaryKey;

namespace Application.Finance.Quiries.proccTAXPostingSetup.GetTAXPostingSetupLoadByPrimaryKey
{ 
	 
	#region proccTAXPostingSetupLoadByPrimaryKey  
    
    
    
      public class GetproccTAXPostingSetupLoadByPrimaryKeyQueryHandler : IRequestHandler<GetproccTAXPostingSetupLoadByPrimaryKey, GetproccTAXPostingSetupLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccTAXPostingSetupLoadByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccTAXPostingSetupLoadAllListVM> Handle(GetproccTAXPostingSetupLoadByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<CTaxPostingSetup> proccTAXPostingSetupLoadByPrimaryKeys = await _procedureAdabter
               .Execute<CTaxPostingSetup>("[FINA].proc_c_TAX_Posting_SetupLoadByPrimaryKey", request);
            GetproccTAXPostingSetupLoadAllListVM vm = new GetproccTAXPostingSetupLoadAllListVM
            {
                proccTAXPostingSetupLoadAlls = _mapper.Map<IList<CTaxPostingSetup>, IList<GetproccTAXPostingSetupLoadAllVM>>(proccTAXPostingSetupLoadByPrimaryKeys)
            };

            return vm;
        }
         #endregion
    }
    
    
    
		
	  
	
		
	
    
}

