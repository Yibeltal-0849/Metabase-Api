using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procVehicleFuelCount.GetprocVehicleFuelCountLoadAll
{
    class GetprocVehicleFuelCountLoadAllQueryHandler : IRequestHandler<GetprocVehicleFuelCountLoadAllQuery, GetprocVehicleFuelCountLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocVehicleFuelCountLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVehicleFuelCountLoadAllListVm> Handle(GetprocVehicleFuelCountLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<VehicleFuelCount> procVehicleFuelCounts = await _procedureAdabter
               .Execute<VehicleFuelCount>("[Vehicle].[proc_Vehicle_FuelCountLoadAll]");
            GetprocVehicleFuelCountLoadAllListVm vm = new GetprocVehicleFuelCountLoadAllListVm
            {
                procVehicleFuelCounts = _mapper.Map<IList<VehicleFuelCount>, IList<GetprocVehicleFuelCountLoadAllVm>>(procVehicleFuelCounts)
            };

            return vm;
        }
    }
}
