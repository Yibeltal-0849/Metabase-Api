
using MediatR;
using AutoMapper;
using System.Collections.Generic;
using XOKA.Domain.Interfaces;
using System.Threading;
using XOKA.Domain.Entities.Finance;
using System.Threading.Tasks;

namespace Application.Finance.Quiries.procAccountPropose.GetprocAccountProposeLoadAll
{ 
	 
	#region procAccountProposeLoadAll  
      public class GetprocAccountProposeLoadAllQueryHandler : IRequestHandler<GetprocAccountProposeLoadAllQuery, GetprocAccountProposeLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocAccountProposeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAccountProposeLoadAllListVM> Handle(GetprocAccountProposeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<AccountPropose> AccountPropose = await _procedureAdabter
               .Execute<AccountPropose>("[FINA].proc_Account_ProposeLoadAll");
          
            GetprocAccountProposeLoadAllListVM vm = new GetprocAccountProposeLoadAllListVM
            {
                procAccountProposeLoadAlls = _mapper.Map<IList<AccountPropose>, IList<GetprocAccountProposeLoadAllVM>>(AccountPropose)
            };

            return vm;
        }
    }

        #endregion
		

    
}

