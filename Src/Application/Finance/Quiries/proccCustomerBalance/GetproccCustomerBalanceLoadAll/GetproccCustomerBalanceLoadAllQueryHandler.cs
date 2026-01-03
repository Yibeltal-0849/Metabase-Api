using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccCustomerBalance.GetproccCustomerBalanceLoadAll
{
    class GetproccCustomerBalanceLoadAllQueryHandler : IRequestHandler<GetproccCustomerBalanceLoadAllQuery, GetproccCustomerBalanceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccCustomerBalanceLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccCustomerBalanceLoadAllListVm> Handle(GetproccCustomerBalanceLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CCustomerBalance> proccCustomerBalances = await _procedureAdabter
               .Execute<CCustomerBalance>("[FINA].[proc_c_Customer_BalanceLoadAll]");
            GetproccCustomerBalanceLoadAllListVm vm = new GetproccCustomerBalanceLoadAllListVm
            {
                proccCustomerBalances = _mapper.Map<IList<CCustomerBalance>, IList<GetproccCustomerBalanceLoadAllVm>>(proccCustomerBalances)
            };

            return vm;
        }
    }
}
