

using MediatR;
using AutoMapper;
using System.Collections.Generic;
using XOKA.Domain.Interfaces;
using System.Threading;
using XOKA.Domain.Entities.Finance;
using System.Threading.Tasks;

namespace Application.Finance.Quiries.procAdAccountingMethod.GetprocAdAccountingMethodLoadAll
{ 
	 
	#region procAdAccountingMethodLoadAll  
      public class GetprocAdAccountingMethodLoadAllQueryHandler : IRequestHandler<GetprocAdAccountingMethodLoadAllQuery, GetprocAdAccountingMethodLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocAdAccountingMethodLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAdAccountingMethodLoadAllListVM> Handle(GetprocAdAccountingMethodLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<AdAccountingMethod> procAdAccountingMethodLoadAlls = await _procedureAdabter
               .Execute<AdAccountingMethod>("[FINA].proc_Ad_Accounting_MethodLoadAll");
            GetprocAdAccountingMethodLoadAllListVM vm = new GetprocAdAccountingMethodLoadAllListVM
            {
                procAdAccountingMethodLoadAlls = _mapper.Map<IList<AdAccountingMethod>, IList<GetprocAdAccountingMethodLoadAllVM>>(procAdAccountingMethodLoadAlls)
            };

            return vm;
        }
    }

        #endregion
    
}

