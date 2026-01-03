using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procVehicle.GetprocVehicleLoadAll
{
    class GetprocVehicleLoadAllQueryHandler : IRequestHandler<GetprocVehicleLoadAllQuery, GetprocVehicleLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocVehicleLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVehicleLoadAllListVm> Handle(GetprocVehicleLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<_Vehicle> procVehicles = await _procedureAdabter
               .Execute<_Vehicle>("[Vehicle].[proc_VehicleLoadAll]");
            GetprocVehicleLoadAllListVm vm = new GetprocVehicleLoadAllListVm
            {
                procVehicles = _mapper.Map<IList<_Vehicle>, IList<GetprocVehicleLoadAllVm>>(procVehicles)
            };

            return vm;
        }
    }
}
