using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccChartOfAccount.GetproccChartOfAccountLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccChartOfAccount.GetproccChartOfAccountByPrimaryKey
{
    public class GetproccChartOfAccountQueryHandler : IRequestHandler<GetproccChartOfAccountByPrimaryKey, GetproccChartOfAccountLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccChartOfAccountQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccChartOfAccountLoadAllListVm> Handle(GetproccChartOfAccountByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CChartOfAccount> proccChartOfAccounts = await _procedureAdabter
               .Execute<CChartOfAccount>("[FINA].[proc_c_Chart_Of_AccountLoadByPrimaryKey]", request);
            GetproccChartOfAccountLoadAllListVm vm = new GetproccChartOfAccountLoadAllListVm
            {
                proccChartOfAccounts = _mapper.Map<IList<CChartOfAccount>, IList<GetproccChartOfAccountLoadAllVm>>(proccChartOfAccounts)
            };

            return vm;
        }
    }
}
