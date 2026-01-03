using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Vehicle.Quiries.procVehicleFuelCount.GetprocVehicleFuelCountLoadAll;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procVehicleFuelCount.GetprocVehicleFuelCountByPrimaryKey
{
    public class GetprocVehicleFuelCountQueryHandler : IRequestHandler<GetprocVehicleFuelCountByPrimaryKey, GetprocVehicleFuelCountLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocVehicleFuelCountQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVehicleFuelCountLoadAllListVm> Handle(GetprocVehicleFuelCountByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<VehicleFuelCount> procVehicleFuelCounts = await _procedureAdabter
               .Execute<VehicleFuelCount>("[Vehicle].[proc_Vehicle_FuelCountLoadByPrimaryKey]", request);
            GetprocVehicleFuelCountLoadAllListVm vm = new GetprocVehicleFuelCountLoadAllListVm
            {
                procVehicleFuelCounts = _mapper.Map<IList<VehicleFuelCount>, IList<GetprocVehicleFuelCountLoadAllVm>>(procVehicleFuelCounts)
            };

            return vm;
        }
    }
}
