using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Vehicle.Quiries.procActiveVehicle.GetprocActiveVehicleLoadAll;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procActiveVehicle.GetprocActiveVehicleByPrimaryKey
{
    public class GetprocActiveVehicleQueryHandler : IRequestHandler<GetprocActiveVehicleByPrimaryKey, GetprocActiveVehicleLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocActiveVehicleQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocActiveVehicleLoadAllListVm> Handle(GetprocActiveVehicleByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<ActiveVehicle> procActiveVehicles = await _procedureAdabter
               .Execute<ActiveVehicle>("[Vehicle].[proc_Active_VehicleLoadByPrimaryKey]", request);
            GetprocActiveVehicleLoadAllListVm vm = new GetprocActiveVehicleLoadAllListVm
            {
                procActiveVehicles = _mapper.Map<IList<ActiveVehicle>, IList<GetprocActiveVehicleLoadAllVm>>(procActiveVehicles)
            };

            return vm;
        }
    }
}
