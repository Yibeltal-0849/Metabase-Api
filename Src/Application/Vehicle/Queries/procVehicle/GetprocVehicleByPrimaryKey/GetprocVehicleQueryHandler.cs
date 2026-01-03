using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Vehicle.Quiries.procVehicle.GetprocVehicleLoadAll;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procVehicle.GetprocVehicleByPrimaryKey
{
    public class GetprocVehicleQueryHandler : IRequestHandler<GetprocVehicleByPrimaryKey, GetprocVehicleLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocVehicleQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVehicleLoadAllListVm> Handle(GetprocVehicleByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<_Vehicle> procVehicles = await _procedureAdabter
               .Execute<_Vehicle>("[Vehicle].[proc_VehicleLoadByPrimaryKey]", request);
            GetprocVehicleLoadAllListVm vm = new GetprocVehicleLoadAllListVm
            {
                procVehicles = _mapper.Map<IList<_Vehicle>, IList<GetprocVehicleLoadAllVm>>(procVehicles)
            };

            return vm;
        }
    }
}
