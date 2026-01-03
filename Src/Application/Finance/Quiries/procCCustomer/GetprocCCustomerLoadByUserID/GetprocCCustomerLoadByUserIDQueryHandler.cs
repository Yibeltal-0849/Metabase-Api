 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.procCCustomer.GetprocCCustomerLoadAll;
using Application.Finance.Quiries.procCCustomer.GetprocCCustomerLoadByUserID;

namespace Application.Finance.Quiries.procCCustomer.GetprocCCustomerLoadByUserID
{ 
	 
	#region procCCustomerLoadByPrimaryKey  
    
    
    
      public class GetprocCCustomerLoadByUserIDQueryHandler : IRequestHandler<GetprocCCustomerLoadByUserID, GetprocCCustomerLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCCustomerLoadByUserIDQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCCustomerLoadAllListVM> Handle(GetprocCCustomerLoadByUserID request, CancellationToken cancellationToken)
        {
            IList< CCustomer> procCCustomerLoadByPrimaryKeys = await _procedureAdabter
               .Execute<CCustomer>("[FINA].[proc_C_CustomerLoadByUserID]", request);
            GetprocCCustomerLoadAllListVM vm = new GetprocCCustomerLoadAllListVM
            {
                procCCustomerLoadAlls = _mapper.Map<IList<CCustomer>, IList<GetprocCCustomerLoadAllVM>>(procCCustomerLoadByPrimaryKeys)
            };

            return vm;
        }
         #endregion
    }
    
    
    
		
	  
	
		
	
    
}

