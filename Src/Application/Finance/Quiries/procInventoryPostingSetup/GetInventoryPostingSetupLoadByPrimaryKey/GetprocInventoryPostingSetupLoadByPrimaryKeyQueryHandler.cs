 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.procInventoryPostingSetup.GetprocInventoryPostingSetupLoadAll;
using Application.Finance.Quiries.procInventoryPostingSetup.GetInventoryPostingSetupLoadByPrimaryKey;

namespace Application.Finance.Quiries.procInventoryPostingSetup.GetInventoryPostingSetupLoadByPrimary
{ 
	 
	#region procInventoryPostingSetupLoadByPrimaryKey  
    
    
    
      public class GetprocInventoryPostingSetupLoadByPrimaryKeyQueryHandler : IRequestHandler<GetprocInventoryPostingSetupLoadByPrimaryKey, GetprocInventoryPostingSetupLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocInventoryPostingSetupLoadByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocInventoryPostingSetupLoadAllListVM> Handle(GetprocInventoryPostingSetupLoadByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<InventoryPostingSetup> procInventoryPostingSetupLoadByPrimaryKeys = await _procedureAdabter
               .Execute<InventoryPostingSetup>("[FINA].proc_Inventory_Posting_SetupLoadByPrimaryKey", request);
            GetprocInventoryPostingSetupLoadAllListVM vm = new GetprocInventoryPostingSetupLoadAllListVM
            {
                procInventoryPostingSetupLoadAlls = _mapper.Map<IList< InventoryPostingSetup >, IList<GetprocInventoryPostingSetupLoadAllVM>>(procInventoryPostingSetupLoadByPrimaryKeys)
            };

            return vm;
        }
         #endregion
    }
    
    
    
		
	  
	
		
	
    
}

