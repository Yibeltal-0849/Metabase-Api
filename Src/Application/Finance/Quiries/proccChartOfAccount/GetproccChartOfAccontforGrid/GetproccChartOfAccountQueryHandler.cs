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

namespace Application.Finance.Quiries.proccChartOfAccount.GetproccChartOfAccontforGrid
{
    public class GetproccChartOfAccountgrideQueryHandler : IRequestHandler<GetproccChartOfAccontforGrid, GetproccChartOfAccountLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccChartOfAccountgrideQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccChartOfAccountLoadAllListVm> Handle(GetproccChartOfAccontforGrid request, CancellationToken cancellationToken)
        {
           
            IList<CChartOfAccount> proccChartOfAccounts = await _procedureAdabter
               .Execute<CChartOfAccount>("[FINA].[proc_c_Chart_Of_AccountLoadForGride]", request);
            GetproccChartOfAccountLoadAllListVm vm = new GetproccChartOfAccountLoadAllListVm
            {
                proccChartOfAccounts = _mapper.Map<IList<CChartOfAccount>, IList<GetproccChartOfAccountLoadAllVm>>(proccChartOfAccounts)
            };

            return vm;
        }
    }
}
