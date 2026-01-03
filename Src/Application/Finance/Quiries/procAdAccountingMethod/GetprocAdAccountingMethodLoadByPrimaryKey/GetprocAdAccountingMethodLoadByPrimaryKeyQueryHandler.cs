 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance; 
using Application.Finance.Quiries.procAdAccountingMethod.GetprocAdAccountingMethodLoadAll;

namespace Application.Finance.Quiries.procAdAccountingMethod.GetprocAdAccountingMethodLoadByPrimaryKey
{ 
	 
	#region procAdAccountingMethodLoadByPrimaryKey  
    
    
    
      public class GetprocAdAccountingMethodLoadByPrimaryKeyQueryHandler : IRequestHandler<GetprocAdAccountingMethodLoadByPrimaryKey, GetprocAdAccountingMethodLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocAdAccountingMethodLoadByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAdAccountingMethodLoadAllListVM> Handle(GetprocAdAccountingMethodLoadByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<AdAccountingMethod> procAdAccountingMethodLoadByPrimaryKeys = await _procedureAdabter
               .Execute<AdAccountingMethod>("[FINA].proc_Ad_Accounting_MethodLoadByPrimaryKey", request);
            GetprocAdAccountingMethodLoadAllListVM vm = new GetprocAdAccountingMethodLoadAllListVM
            {
                procAdAccountingMethodLoadAlls = _mapper.Map<IList<AdAccountingMethod>, IList<GetprocAdAccountingMethodLoadAllVM>>(procAdAccountingMethodLoadByPrimaryKeys)
            };

            return vm;
        }
         #endregion
    }
    
    
    
		
	  
	
		
	
    
}

