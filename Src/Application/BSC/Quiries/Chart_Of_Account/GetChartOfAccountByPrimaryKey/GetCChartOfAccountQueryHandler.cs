using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.BSC.Quiries.Chart_Of_Account.GetCChartOfAccountLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Chart_Of_Account.GetCChartOfAccountByPrimaryKey
{
    public class GetCChartOfAccountQueryHandler : IRequestHandler<GetCChartOfAccountByPrimaryKey, GetCChartOfAccountLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetCChartOfAccountQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCChartOfAccountLoadAllListVm> Handle(GetCChartOfAccountByPrimaryKey request, CancellationToken cancellationToken)
        {
            string Account_ID = request.Account_ID;
            IList<Proc_C_Chart_Of_Account> chartOfAccounts = await _procedureAdabter
               .Execute<Proc_C_Chart_Of_Account>("[BSC].[proc_c_Chart_Of_AccountLoadByPrimaryKey]", (nameof(Account_ID), Account_ID));
            GetCChartOfAccountLoadAllListVm vm = new GetCChartOfAccountLoadAllListVm
            {
                ChartOfAccounts = _mapper.Map<IList<Proc_C_Chart_Of_Account>, IList<GetCChartOfAccountLoadAllVm>>(chartOfAccounts)
            };

            return vm;
        }
    }
}
