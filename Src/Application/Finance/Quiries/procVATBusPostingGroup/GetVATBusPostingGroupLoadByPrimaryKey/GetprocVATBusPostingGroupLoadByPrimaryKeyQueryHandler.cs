 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.procVATBusPostingGroup.GetprocVATBusPostingGroupLoadAll;

namespace Application.Finance.Quiries.procVATBusPostingGroup.GetVATBusPostingGroupLoadByPrimaryKey
{ 
	 
	#region procVATBusPostingGroupLoadByPrimaryKey  
    
    
    
      public class GetprocVATBusPostingGroupLoadByPrimaryKeyQueryHandler : IRequestHandler<GetprocVATBusPostingGroupLoadByPrimaryKey, GetprocVATBusPostingGroupLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocVATBusPostingGroupLoadByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVATBusPostingGroupLoadAllListVM> Handle(GetprocVATBusPostingGroupLoadByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<GenBusPostingGroups> procVATBusPostingGroupLoadByPrimaryKeys = await _procedureAdabter
               .Execute<GenBusPostingGroups>("[FINA].[proc_VAT_Bus_Posting_GroupLoadByPrimaryKey]", request);
            GetprocVATBusPostingGroupLoadAllListVM vm = new GetprocVATBusPostingGroupLoadAllListVM
            {
                procVATBusPostingGroupLoadAlls = _mapper.Map<IList<GenBusPostingGroups>, IList<GetprocVATBusPostingGroupLoadAllVM>>(procVATBusPostingGroupLoadByPrimaryKeys)
            };

            return vm;
        }
         #endregion
    }
    
    
    
		
	  
	
		
	
    
}

