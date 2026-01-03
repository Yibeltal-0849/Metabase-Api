 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.procAdBusinessType.GetprocAdBusinessTypeLoadAll;

namespace Application.Finance.Quiries.procAdBusinessType.GetprocAdBusinessTypeLoadByPrimaryKey
{ 
	 
	#region procAdBusinessTypeLoadByPrimaryKey  
    
    
    
      public class GetprocAdBusinessTypeLoadByPrimaryKeyQueryHandler : IRequestHandler<GetprocAdBusinessTypeLoadByPrimaryKey, GetprocAdBusinessTypeLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocAdBusinessTypeLoadByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAdBusinessTypeLoadAllListVM> Handle(GetprocAdBusinessTypeLoadByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<AdBusinessType> procAdBusinessTypeLoadByPrimaryKeys = await _procedureAdabter
               .Execute<AdBusinessType>("[FINA].proc_Ad_Business_TypeLoadByPrimaryKey", request);
            GetprocAdBusinessTypeLoadAllListVM vm = new GetprocAdBusinessTypeLoadAllListVM
            {
                procAdBusinessTypeLoadAlls = _mapper.Map<IList<AdBusinessType>, IList<GetprocAdBusinessTypeLoadAllVM>>(procAdBusinessTypeLoadByPrimaryKeys)
            };

            return vm;
        }
         #endregion
    }
    
    
    
		
	  
	
		
	
    
}

