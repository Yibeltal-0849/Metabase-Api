using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccCABeginningBalance.GetproccCABeginningBalanceLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccCABeginningBalance.GetproccCABeginningBalanceByPrimaryKey
{
    public class GetproccCABeginningBalanceQueryHandler : IRequestHandler<GetproccCABeginningBalanceByPrimaryKey, GetproccCABeginningBalanceLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproccCABeginningBalanceQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccCABeginningBalanceLoadAllListVm> Handle(GetproccCABeginningBalanceByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CCaBeginningBalance> proccCABeginningBalances = await _procedureAdabter
               .Execute<CCaBeginningBalance>("[FINA].[proc_c_CA_Beginning_BalanceLoadByPrimaryKey]", request);
            GetproccCABeginningBalanceLoadAllListVm vm = new GetproccCABeginningBalanceLoadAllListVm
            {
                proccCABeginningBalances = _mapper.Map<IList<CCaBeginningBalance>, IList<GetproccCABeginningBalanceLoadAllVm>>(proccCABeginningBalances)
            };

            return vm;
        }
    }
}
