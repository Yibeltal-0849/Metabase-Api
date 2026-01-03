using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.BSC.Quiries.Company_Strategy.GetCompanyStrategyLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Company_Strategy.GetCompanyStrategyByPrimaryKey
{
    public class GetCompanyStrategyQueryHandler : IRequestHandler<GetCompanyStrategyByPrimaryKey, GetCompanyStrategyLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetCompanyStrategyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCompanyStrategyLoadAllListVm> Handle(GetCompanyStrategyByPrimaryKey request, CancellationToken cancellationToken)
        {
            string Strategy_NO = request.Strategy_NO;
            IList<Proc_Company_Strategy> companyStrategies = await _procedureAdabter
               .Execute<Proc_Company_Strategy>("[BSC].[proc_Company_StrategyLoadByPrimaryKey]", (nameof(Strategy_NO), Strategy_NO));
            GetCompanyStrategyLoadAllListVm vm = new GetCompanyStrategyLoadAllListVm
            {
                CompanyStrategies = _mapper.Map<IList<Proc_Company_Strategy>, IList<GetCompanyStrategyLoadAllVm>>(companyStrategies)
            };

            return vm;
        }
    }
}
