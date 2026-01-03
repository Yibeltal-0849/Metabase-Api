
using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procVATBusPostingGroup.GetprocVATBusPostingGroupLoadAll
{ 
	 
	#region procVATBusPostingGroupLoadAll  
      public class GetprocVATBusPostingGroupLoadAllQueryHandler : IRequestHandler<GetprocVATBusPostingGroupLoadAllQuery, GetprocVATBusPostingGroupLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocVATBusPostingGroupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVATBusPostingGroupLoadAllListVM> Handle(GetprocVATBusPostingGroupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<GenBusPostingGroups> procVATBusPostingGroupLoadAlls = await _procedureAdabter
               .Execute<GenBusPostingGroups>("[FINA].proc_VAT_Bus_Posting_GroupLoadAll");
            GetprocVATBusPostingGroupLoadAllListVM vm = new GetprocVATBusPostingGroupLoadAllListVM
            {
                procVATBusPostingGroupLoadAlls = _mapper.Map<IList<GenBusPostingGroups>, IList<GetprocVATBusPostingGroupLoadAllVM>>(procVATBusPostingGroupLoadAlls)
            };

            return vm;
        }
    }
}
        #endregion
		
	  
	
		
	
    
