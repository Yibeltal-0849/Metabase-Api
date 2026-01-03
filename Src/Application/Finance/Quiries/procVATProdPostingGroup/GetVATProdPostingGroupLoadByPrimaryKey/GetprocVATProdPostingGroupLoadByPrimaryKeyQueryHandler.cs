 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.procVATProdPostingGroup.GetprocVATProdPostingGroupLoadAll;

namespace Application.Finance.Quiries.procVATProdPostingGroup.GetVATProdPostingGroupLoadByPrimaryKey
{ 
	 
	#region procVATProdPostingGroupLoadByPrimaryKey  
    
    
    
      public class GetprocVATProdPostingGroupLoadByPrimaryKeyQueryHandler : IRequestHandler<GetprocVATProdPostingGroupLoadByPrimaryKey, GetprocVATProdPostingGroupLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocVATProdPostingGroupLoadByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVATProdPostingGroupLoadAllListVM> Handle(GetprocVATProdPostingGroupLoadByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<GenProductPostingGroup> procVATProdPostingGroupLoadByPrimaryKeys = await _procedureAdabter
               .Execute<GenProductPostingGroup>("[FINA].[proc_VAT_Prod_Posting_GroupLoadByPrimaryKey]", request);
            GetprocVATProdPostingGroupLoadAllListVM vm = new GetprocVATProdPostingGroupLoadAllListVM
            {
                procVATProdPostingGroupLoadAlls = _mapper.Map<IList<GenProductPostingGroup>, IList<GetprocVATProdPostingGroupLoadAllVM>>(procVATProdPostingGroupLoadByPrimaryKeys)
            };

            return vm;
        }
         #endregion
    }
    
    
    
		
	  
	
		
	
    
}

