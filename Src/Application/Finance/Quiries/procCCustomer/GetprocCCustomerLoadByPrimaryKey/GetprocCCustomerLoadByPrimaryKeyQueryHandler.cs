 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.procCCustomer.GetprocCCustomerLoadAll;
using Application.Finance.Quiries.procCCustomer.GetCCustomerLoadByPrimaryKey;

namespace Application.Finance.Quiries.procCCustomer.GetCCustomerLoadByPrimaryKey
{ 
	 
	#region procCCustomerLoadByPrimaryKey  
    
    
    
      public class GetprocCCustomerLoadByPrimaryKeyQueryHandler : IRequestHandler<GetprocCCustomerLoadByPrimaryKey, GetprocCCustomerLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCCustomerLoadByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCCustomerLoadAllListVM> Handle(GetprocCCustomerLoadByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList< CCustomer> procCCustomerLoadByPrimaryKeys = await _procedureAdabter
               .Execute<CCustomer>("[FINA].proc_C_CustomerLoadByPrimaryKey", request);
            GetprocCCustomerLoadAllListVM vm = new GetprocCCustomerLoadAllListVM
            {
                procCCustomerLoadAlls = _mapper.Map<IList<CCustomer>, IList<GetprocCCustomerLoadAllVM>>(procCCustomerLoadByPrimaryKeys)
            };

            return vm;
        }
         #endregion
    }
    
    
    
		
	  
	
		
	
    
}

