using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procFleetContract.GetprocFleetContractLoadAll
{
    class GetprocFleetContractLoadAllQueryHandler : IRequestHandler<GetprocFleetContractLoadAllQuery, GetprocFleetContractLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocFleetContractLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFleetContractLoadAllListVm> Handle(GetprocFleetContractLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<FleetContract> procFleetContracts = await _procedureAdabter
               .Execute<FleetContract>("[FINA].[proc_Fleet_ContractLoadAll]");
            GetprocFleetContractLoadAllListVm vm = new GetprocFleetContractLoadAllListVm
            {
                procFleetContracts = _mapper.Map<IList<FleetContract>, IList<GetprocFleetContractLoadAllVm>>(procFleetContracts)
            };

            return vm;
        }
    }
}
