

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccVATPostingSetup.GetproccVATPostingSetupLoadAll
{ 
	 
	#region proccVATPostingSetupLoadAll  
      public class GetproccVATPostingSetupLoadAllQueryHandler : IRequestHandler<GetproccVATPostingSetupLoadAllQuery, GetproccVATPostingSetupLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccVATPostingSetupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccVATPostingSetupLoadAllListVM> Handle(GetproccVATPostingSetupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CTaxPostingSetup> proccVATPostingSetupLoadAlls = await _procedureAdabter
               .Execute<CTaxPostingSetup>("[FINA].proc_c_VAT_Posting_SetupLoadAll");
            GetproccVATPostingSetupLoadAllListVM vm = new GetproccVATPostingSetupLoadAllListVM
            {
                proccVATPostingSetupLoadAlls = _mapper.Map<IList<CTaxPostingSetup>, IList<GetproccVATPostingSetupLoadAllVM>>(proccVATPostingSetupLoadAlls)
            };

            return vm;
        }
    }

        #endregion
		
	  
	
		
	
    
}

