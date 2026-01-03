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

namespace Application.Finance.Quiries.proccChartOfAccount.GetproccChartOfAccountByPropose_Type
{
    public class GetproccChartOfAccountByPropose_TypeQueryHandler : IRequestHandler<GetproccChartOfAccountByPropose_Type, GetproccChartOfAccountLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccChartOfAccountByPropose_TypeQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccChartOfAccountLoadAllListVm> Handle(GetproccChartOfAccountByPropose_Type request, CancellationToken cancellationToken)
        {
           
            IList<CChartOfAccount> proccChartOfAccounts = await _procedureAdabter
               .Execute<CChartOfAccount>("[FINA].[proc_c_Chart_Of_AccountLoadByPropose_Type]", request);
            GetproccChartOfAccountLoadAllListVm vm = new GetproccChartOfAccountLoadAllListVm
            {
                proccChartOfAccounts = _mapper.Map<IList<CChartOfAccount>, IList<GetproccChartOfAccountLoadAllVm>>(proccChartOfAccounts)
            };

            return vm;
        }
    }
}
