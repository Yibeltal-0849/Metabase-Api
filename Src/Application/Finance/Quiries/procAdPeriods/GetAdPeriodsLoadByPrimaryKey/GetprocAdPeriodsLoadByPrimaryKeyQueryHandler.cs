 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.procAdPeriods.GetprocAdPeriodsLoadAll;
using Application.Finance.Quiries.procAdPeriods.GetAdPeriodsLoadByPrimaryKey;

namespace Application.Finance.Quiries.procAdPeriods.GetAdPeriodsLoadByPrimaryKey
{

    #region procAdPeriodsLoadByPrimaryKey  



    public class GetprocAdPeriodsLoadByPrimaryKeyQueryHandler : IRequestHandler<GetprocAdPeriodsLoadByPrimaryKey, GetprocAdPeriodsLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocAdPeriodsLoadByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocAdPeriodsLoadAllListVM> Handle(GetprocAdPeriodsLoadByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<AdPeriods> procAdPeriodsLoadByPrimaryKeys = await _procedureAdabter
               .Execute<AdPeriods>("[FINA].proc_Ad_PeriodsLoadByPrimaryKey", request);
            GetprocAdPeriodsLoadAllListVM vm = new GetprocAdPeriodsLoadAllListVM
            {
                procAdPeriodsLoadAlls = _mapper.Map<IList<AdPeriods>, IList<GetprocAdPeriodsLoadAllVM>>(procAdPeriodsLoadByPrimaryKeys)
            };

            return vm;
        } 
    }
         #endregion
    
    
    
    
		
	  
	
		
	
    
}

