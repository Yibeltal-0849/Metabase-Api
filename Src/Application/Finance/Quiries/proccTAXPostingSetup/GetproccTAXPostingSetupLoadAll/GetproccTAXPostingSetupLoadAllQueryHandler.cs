

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccTAXPostingSetup.GetproccTAXPostingSetupLoadAll
{ 
	 
	#region proccTAXPostingSetupLoadAll  
      public class GetproccTAXPostingSetupLoadAllQueryHandler : IRequestHandler<GetproccTAXPostingSetupLoadAllQuery, GetproccTAXPostingSetupLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccTAXPostingSetupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccTAXPostingSetupLoadAllListVM> Handle(GetproccTAXPostingSetupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CTaxPostingSetup> proccTAXPostingSetupLoadAlls = await _procedureAdabter
               .Execute<CTaxPostingSetup>("[FINA].proc_c_TAX_Posting_SetupLoadAll");
            GetproccTAXPostingSetupLoadAllListVM vm = new GetproccTAXPostingSetupLoadAllListVM
            {
                proccTAXPostingSetupLoadAlls = _mapper.Map<IList<CTaxPostingSetup>, IList<GetproccTAXPostingSetupLoadAllVM>>(proccTAXPostingSetupLoadAlls)
            };

            return vm;
        }
    
}
        #endregion
		
	  
	
		
	
    
}

