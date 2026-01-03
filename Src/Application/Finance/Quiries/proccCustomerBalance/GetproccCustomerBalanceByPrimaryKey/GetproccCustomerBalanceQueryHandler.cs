using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccCustomerBalance.GetproccCustomerBalanceLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccCustomerBalance.GetproccCustomerBalanceByPrimaryKey
{
    public class GetproccCustomerBalanceQueryHandler : IRequestHandler<GetproccCustomerBalanceByPrimaryKey, GetproccCustomerBalanceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccCustomerBalanceQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccCustomerBalanceLoadAllListVm> Handle(GetproccCustomerBalanceByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CCustomerBalance> proccCustomerBalances = await _procedureAdabter
               .Execute<CCustomerBalance>("[FINA].[proc_c_Customer_BalanceLoadByPrimaryKey]", request);
            GetproccCustomerBalanceLoadAllListVm vm = new GetproccCustomerBalanceLoadAllListVm
            {
                proccCustomerBalances = _mapper.Map<IList<CCustomerBalance>, IList<GetproccCustomerBalanceLoadAllVm>>(proccCustomerBalances)
            };

            return vm;
        }
    }
}
