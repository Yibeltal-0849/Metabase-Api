using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Vehicle.Quiries.procFleetContract.GetprocFleetContractLoadAll;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procFleetContract.GetprocFleetContractByPrimaryKey
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
               .Execute<FleetContract>("[Vehicle].[proc_Fleet_ContractLoadByPrimaryKey]", request);
            GetprocFleetContractLoadAllListVm vm = new GetprocFleetContractLoadAllListVm
            {
                procFleetContracts = _mapper.Map<IList<FleetContract>, IList<GetprocFleetContractLoadAllVm>>(procFleetContracts)
            };

            return vm;
        }
    }
}
