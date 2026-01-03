using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procVehicleLease.GetprocVehicleLeaseLoadAll
{
    class GetprocVehicleLeaseLoadAllQueryHandler : IRequestHandler<GetprocVehicleLeaseLoadAllQuery, GetprocVehicleLeaseLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocVehicleLeaseLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVehicleLeaseLoadAllListVm> Handle(GetprocVehicleLeaseLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<VehicleLease> procVehicleLeases = await _procedureAdabter
               .Execute<VehicleLease>("[Vehicle].[proc_Vehicle_LeaseLoadAll]");
            GetprocVehicleLeaseLoadAllListVm vm = new GetprocVehicleLeaseLoadAllListVm
            {
                procVehicleLeases = _mapper.Map<IList<VehicleLease>, IList<GetprocVehicleLeaseLoadAllVm>>(procVehicleLeases)
            };

            return vm;
        }
    }
}
