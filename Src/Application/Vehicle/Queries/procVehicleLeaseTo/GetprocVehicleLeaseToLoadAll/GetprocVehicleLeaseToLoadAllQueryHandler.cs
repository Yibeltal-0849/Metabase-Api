using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procVehicleLeaseTo.GetprocVehicleLeaseToLoadAll
{
    class GetprocVehicleLeaseToLoadAllQueryHandler : IRequestHandler<GetprocVehicleLeaseToLoadAllQuery, GetprocVehicleLeaseToLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocVehicleLeaseToLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVehicleLeaseToLoadAllListVm> Handle(GetprocVehicleLeaseToLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<VehicleLeaseTo> procVehicleLeaseTos = await _procedureAdabter
               .Execute<VehicleLeaseTo>("[Vehicle].[proc_Vehicle_LeaseToLoadAll]");
            GetprocVehicleLeaseToLoadAllListVm vm = new GetprocVehicleLeaseToLoadAllListVm
            {
                procVehicleLeaseTos = _mapper.Map<IList<VehicleLeaseTo>, IList<GetprocVehicleLeaseToLoadAllVm>>(procVehicleLeaseTos)
            };

            return vm;
        }
    }
}
