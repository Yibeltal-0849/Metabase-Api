using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccInventoryBeginingBalances.GetproccInventoryBeginingBalancesLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccInventoryBeginingBalances.GetproccInventoryBeginingBalancesByPrimaryKey
{
    public class GetproccInventoryBeginingBalancesQueryHandler : IRequestHandler<GetproccInventoryBeginingBalancesByPrimaryKey, GetproccInventoryBeginingBalancesLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccInventoryBeginingBalancesQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccInventoryBeginingBalancesLoadAllListVm> Handle(GetproccInventoryBeginingBalancesByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CInventoryBeginingBalances> proccInventoryBeginingBalancess = await _procedureAdabter
               .Execute<CInventoryBeginingBalances>("[FINA].[proc_c_Inventory_Begining_BalancesLoadByPrimaryKey]", request);
            GetproccInventoryBeginingBalancesLoadAllListVm vm = new GetproccInventoryBeginingBalancesLoadAllListVm
            {
                proccInventoryBeginingBalancess = _mapper.Map<IList<CInventoryBeginingBalances>, IList<GetproccInventoryBeginingBalancesLoadAllVm>>(proccInventoryBeginingBalancess)
            };

            return vm;
        }
    }
}
