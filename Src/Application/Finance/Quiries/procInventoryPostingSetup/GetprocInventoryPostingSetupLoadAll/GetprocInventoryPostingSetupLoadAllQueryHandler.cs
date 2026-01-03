

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procInventoryPostingSetup.GetprocInventoryPostingSetupLoadAll
{ 
	 
	#region procInventoryPostingSetupLoadAll  
      public class GetprocInventoryPostingSetupLoadAllQueryHandler : IRequestHandler<GetprocInventoryPostingSetupLoadAllQuery, GetprocInventoryPostingSetupLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocInventoryPostingSetupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocInventoryPostingSetupLoadAllListVM> Handle(GetprocInventoryPostingSetupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<InventoryPostingSetup> procInventoryPostingSetupLoadAlls = await _procedureAdabter
               .Execute<InventoryPostingSetup>("[FINA].[proc_Inventory_Posting_SetupLoadAll]");
            GetprocInventoryPostingSetupLoadAllListVM vm = new GetprocInventoryPostingSetupLoadAllListVM
            {
                procInventoryPostingSetupLoadAlls = _mapper.Map<IList<InventoryPostingSetup>, IList<GetprocInventoryPostingSetupLoadAllVM>>(procInventoryPostingSetupLoadAlls)
            };

            return vm;
        }
    }

        #endregion
		
	  
	
		
	
    
}

