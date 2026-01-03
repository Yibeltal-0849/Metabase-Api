

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procAdBusinessType.GetprocAdBusinessTypeLoadAll
{ 
	 
	#region procAdBusinessTypeLoadAll  
      public class GetprocAdBusinessTypeLoadAllQueryHandler : IRequestHandler<GetprocAdBusinessTypeLoadAllQuery, GetprocAdBusinessTypeLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocAdBusinessTypeLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAdBusinessTypeLoadAllListVM> Handle(GetprocAdBusinessTypeLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<AdBusinessType> procAdBusinessTypeLoadAlls = await _procedureAdabter
               .Execute<AdBusinessType>("[FINA].proc_Ad_Business_TypeLoadAll");
            GetprocAdBusinessTypeLoadAllListVM vm = new GetprocAdBusinessTypeLoadAllListVM
            {
                procAdBusinessTypeLoadAlls = _mapper.Map<IList<AdBusinessType>, IList<GetprocAdBusinessTypeLoadAllVM>>(procAdBusinessTypeLoadAlls)
            };

            return vm;
        }
    }

        #endregion
		
	  
 
}

