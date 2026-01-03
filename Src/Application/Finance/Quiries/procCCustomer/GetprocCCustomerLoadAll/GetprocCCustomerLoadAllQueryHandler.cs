

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procCCustomer.GetprocCCustomerLoadAll
{ 
	 
	#region procCCustomerLoadAll  
      public class GetprocCCustomerLoadAllQueryHandler : IRequestHandler<GetprocCCustomerLoadAllQuery, GetprocCCustomerLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCCustomerLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCCustomerLoadAllListVM> Handle(GetprocCCustomerLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CCustomer> procCCustomerLoadAlls = await _procedureAdabter
               .Execute<CCustomer>("[FINA].proc_C_CustomerLoadAll");
            GetprocCCustomerLoadAllListVM vm = new GetprocCCustomerLoadAllListVM
            {
                procCCustomerLoadAlls = _mapper.Map<IList<CCustomer>, IList<GetprocCCustomerLoadAllVM>>(procCCustomerLoadAlls)
            };

            return vm;
        }
    }

        #endregion
		 

}