

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procVATProdPostingGroup.GetprocVATProdPostingGroupLoadAll
{ 
	 
	#region procVATProdPostingGroupLoadAll  
      public class GetprocVATProdPostingGroupLoadAllQueryHandler : IRequestHandler<GetprocVATProdPostingGroupLoadAllQuery, GetprocVATProdPostingGroupLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocVATProdPostingGroupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVATProdPostingGroupLoadAllListVM> Handle(GetprocVATProdPostingGroupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<GenProductPostingGroup> procVATProdPostingGroupLoadAlls = await _procedureAdabter
               .Execute<GenProductPostingGroup>("[FINA].proc_VAT_Prod_Posting_GroupLoadAll");
            GetprocVATProdPostingGroupLoadAllListVM vm = new GetprocVATProdPostingGroupLoadAllListVM
            {
                procVATProdPostingGroupLoadAlls = _mapper.Map<IList<GenProductPostingGroup>, IList<GetprocVATProdPostingGroupLoadAllVM>>(procVATProdPostingGroupLoadAlls)
            };

            return vm;
        }
    }

        #endregion
		
	  
			
	
    
}

