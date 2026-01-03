using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procFleetContract.GetprocFleetContractLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procFleetContract.GetprocFleetContractByPrimaryKey
{
    public class GetprocFleetContractQueryHandler : IRequestHandler<GetprocFleetContractByPrimaryKey, GetprocFleetContractLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocFleetContractQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFleetContractLoadAllListVm> Handle(GetprocFleetContractByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<FleetContract> procFleetContracts = await _procedureAdabter
               .Execute<FleetContract>("[FINA].[proc_Fleet_ContractLoadByPrimaryKey]", request);
            GetprocFleetContractLoadAllListVm vm = new GetprocFleetContractLoadAllListVm
            {
                procFleetContracts = _mapper.Map<IList<FleetContract>, IList<GetprocFleetContractLoadAllVm>>(procFleetContracts)
            };

            return vm;
        }
    }
}
