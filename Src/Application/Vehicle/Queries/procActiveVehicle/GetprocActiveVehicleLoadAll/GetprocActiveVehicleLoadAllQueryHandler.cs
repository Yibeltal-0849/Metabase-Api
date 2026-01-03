using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procActiveVehicle.GetprocActiveVehicleLoadAll
{
    class GetprocActiveVehicleLoadAllQueryHandler : IRequestHandler<GetprocActiveVehicleLoadAllQuery, GetprocActiveVehicleLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocActiveVehicleLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocActiveVehicleLoadAllListVm> Handle(GetprocActiveVehicleLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<ActiveVehicle> procActiveVehicles = await _procedureAdabter
               .Execute<ActiveVehicle>("[Vehicle].[proc_Active_VehicleLoadAll]");
            GetprocActiveVehicleLoadAllListVm vm = new GetprocActiveVehicleLoadAllListVm
            {
                procActiveVehicles = _mapper.Map<IList<ActiveVehicle>, IList<GetprocActiveVehicleLoadAllVm>>(procActiveVehicles)
            };

            return vm;
        }
    }
}
