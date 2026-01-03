using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Company_Strategy.GetCompanyStrategyLoadAll
{
    public class GetCompanyStrategyLoadAllQueryHandler : IRequestHandler<GetCompanyStrategyLoadAllQuery, GetCompanyStrategyLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetCompanyStrategyLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCompanyStrategyLoadAllListVm> Handle(GetCompanyStrategyLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_Company_Strategy> companyStrategies = await _procedureAdabter
               .Execute<Proc_Company_Strategy>("[BSC].[proc_Company_StrategyLoadAll]");
            GetCompanyStrategyLoadAllListVm vm = new GetCompanyStrategyLoadAllListVm
            {
                CompanyStrategies = _mapper.Map<IList<Proc_Company_Strategy>, IList<GetCompanyStrategyLoadAllVm>>(companyStrategies)
            };

            return vm;
        }
    }
}
