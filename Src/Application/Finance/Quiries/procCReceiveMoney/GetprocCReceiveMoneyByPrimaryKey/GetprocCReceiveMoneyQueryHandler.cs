using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procCReceiveMoney.GetprocCReceiveMoneyLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCReceiveMoney.GetprocCReceiveMoneyByPrimaryKey
{
    public class GetprocCReceiveMoneyQueryHandler : IRequestHandler<GetprocCReceiveMoneyByPrimaryKey, GetprocCReceiveMoneyLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCReceiveMoneyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocCReceiveMoneyLoadAllListVm> Handle(GetprocCReceiveMoneyByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<CReceiveMoney> procCReceiveMoneys = await _procedureAdabter
               .Execute<CReceiveMoney>("[FINA].[proc_C_Receive_MoneyLoadByPrimaryKey]", request);
            GetprocCReceiveMoneyLoadAllListVm vm = new GetprocCReceiveMoneyLoadAllListVm
            {
                procCReceiveMoneys = _mapper.Map<IList<CReceiveMoney>, IList<GetprocCReceiveMoneyLoadAllVm>>(procCReceiveMoneys)
            };

            return vm;
        }
    }
}
