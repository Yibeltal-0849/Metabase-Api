

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procGenProductPostingGroup.GetprocGenProductPostingGroupLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;
using Application.Finance.Quiries.procGenProductPostingGroup.GetGenProductPostingGroupLoadByPrimaryKey;

namespace Application.Finance.Quiries.procGenProductPostingGroup.GetprocGenProductPostingGroupdByPrimaryKey
{ 
	 
	#region procGenProductPostingGroupLoadAll  
      public class GetprocGenProductPostingGroupLoadAllQueryHandler : IRequestHandler<GetprocGenProductPostingGroupLoadByPrimaryKey, GetprocGenProductPostingGroupLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocGenProductPostingGroupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocGenProductPostingGroupLoadAllListVM> Handle(GetprocGenProductPostingGroupLoadByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<GenProductPostingGroup> procGenProductPostingGroupLoadAlls = await _procedureAdabter
               .Execute<GenProductPostingGroup>("[FINA].proc_Gen_Product_Posting_GroupLoadByPrimaryKey", request);
            GetprocGenProductPostingGroupLoadAllListVM vm = new GetprocGenProductPostingGroupLoadAllListVM
            {
                procGenProductPostingGroupLoadAlls = _mapper.Map<IList<GenProductPostingGroup>, IList<GetprocGenProductPostingGroupLoadAllVM>>(procGenProductPostingGroupLoadAlls)
            };

            return vm;
        }
    }

        #endregion
		
	  
	
		
	
    
}

