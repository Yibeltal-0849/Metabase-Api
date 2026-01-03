 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.ProcAdYear.GetProcAdYearLoadAll;
using Application.Finance.Quiries.ProcAdYear.GetProcAdYearLoadByPrimaryKey;

namespace Application.Finance.Quiries.ProcAdYear.GetProcAdYearLoadByPrimaryKey
{

    #region ProcAdYearLoadByPrimaryKey  



    public class GetProcAdYearLoadByPrimaryKeyQueryHandler : IRequestHandler<GetProcAdYearLoadByPrimaryKey, GetProcAdYearLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetProcAdYearLoadByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetProcAdYearLoadAllListVM> Handle(GetProcAdYearLoadByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList<AdYear> ProcAdYearLoadByPrimaryKeys = await _procedureAdabter
               .Execute<AdYear>("[FINA].[proc_Ad_YearLoadByPrimaryKey]", request);
            GetProcAdYearLoadAllListVM vm = new GetProcAdYearLoadAllListVM
            {
                ProcAdYearLoadAlls = _mapper.Map<IList<AdYear>, IList<GetProcAdYearLoadAllVM>>(ProcAdYearLoadByPrimaryKeys)
            };

            return vm;
        } 
    }
         #endregion
    
    
    
    
		
	  
	
		
	
    
}

