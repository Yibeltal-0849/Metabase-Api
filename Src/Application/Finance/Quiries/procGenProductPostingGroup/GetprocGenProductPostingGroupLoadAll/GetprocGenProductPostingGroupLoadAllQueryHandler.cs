

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procGenProductPostingGroup.GetprocGenProductPostingGroupLoadAll
{ 
	 
	#region procGenProductPostingGroupLoadAll  
      public class GetprocGenProductPostingGroupLoadAllQueryHandler : IRequestHandler<GetprocGenProductPostingGroupLoadAllQuery, GetprocGenProductPostingGroupLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocGenProductPostingGroupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocGenProductPostingGroupLoadAllListVM> Handle(GetprocGenProductPostingGroupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<GenProductPostingGroup> procGenProductPostingGroupLoadAlls = await _procedureAdabter
               .Execute<GenProductPostingGroup>("[FINA].proc_Gen_Product_Posting_GroupLoadAll");
            GetprocGenProductPostingGroupLoadAllListVM vm = new GetprocGenProductPostingGroupLoadAllListVM
            {
                procGenProductPostingGroupLoadAlls = _mapper.Map<IList<GenProductPostingGroup>, IList<GetprocGenProductPostingGroupLoadAllVM>>(procGenProductPostingGroupLoadAlls)
            };

            return vm;
        }
    }

        #endregion
		
	  
	
		
	
    
}

