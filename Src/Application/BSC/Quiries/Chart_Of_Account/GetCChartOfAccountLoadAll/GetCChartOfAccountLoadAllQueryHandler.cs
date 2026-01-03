using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Chart_Of_Account.GetCChartOfAccountLoadAll
{
    class GetCChartOfAccountLoadAllQueryHandler : IRequestHandler<GetCChartOfAccountLoadAllQuery, GetCChartOfAccountLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetCChartOfAccountLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCChartOfAccountLoadAllListVm> Handle(GetCChartOfAccountLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_C_Chart_Of_Account> chartOfAccounts = await _procedureAdabter
               .Execute<Proc_C_Chart_Of_Account>("[BSC].[proc_c_Chart_Of_AccountLoadAll]");
            GetCChartOfAccountLoadAllListVm vm = new GetCChartOfAccountLoadAllListVm
            {
                ChartOfAccounts = _mapper.Map<IList<Proc_C_Chart_Of_Account>, IList<GetCChartOfAccountLoadAllVm>>(chartOfAccounts)
            };

            return vm;
        }
    }
}
