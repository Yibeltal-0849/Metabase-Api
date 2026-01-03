using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Vehicle.Quiries.procVehicleLeaseTo.GetprocVehicleLeaseToLoadAll;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procVehicleLeaseTo.GetprocVehicleLeaseToByPrimaryKey
{
    public class GetprocVehicleLeaseToQueryHandler : IRequestHandler<GetprocVehicleLeaseToByPrimaryKey, GetprocVehicleLeaseToLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocVehicleLeaseToQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVehicleLeaseToLoadAllListVm> Handle(GetprocVehicleLeaseToByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<VehicleLeaseTo> procVehicleLeaseTos = await _procedureAdabter
               .Execute<VehicleLeaseTo>("[Vehicle].[proc_Vehicle_LeaseToLoadByPrimaryKey]", request);
            GetprocVehicleLeaseToLoadAllListVm vm = new GetprocVehicleLeaseToLoadAllListVm
            {
                procVehicleLeaseTos = _mapper.Map<IList<VehicleLeaseTo>, IList<GetprocVehicleLeaseToLoadAllVm>>(procVehicleLeaseTos)
            };

            return vm;
        }
    }
}
