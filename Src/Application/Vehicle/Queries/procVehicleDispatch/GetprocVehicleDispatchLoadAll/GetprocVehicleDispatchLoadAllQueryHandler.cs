using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procVehicleDispatch.GetprocVehicleDispatchLoadAll
{
    class GetprocVehicleDispatchLoadAllQueryHandler : IRequestHandler<GetprocVehicleDispatchLoadAllQuery, GetprocVehicleDispatchLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocVehicleDispatchLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVehicleDispatchLoadAllListVm> Handle(GetprocVehicleDispatchLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<VehicleDispatch> procVehicleDispatchs = await _procedureAdabter
               .Execute<VehicleDispatch>("[Vehicle].[proc_Vehicle_DispatchLoadAll]");
            GetprocVehicleDispatchLoadAllListVm vm = new GetprocVehicleDispatchLoadAllListVm
            {
                procVehicleDispatchs = _mapper.Map<IList<VehicleDispatch>, IList<GetprocVehicleDispatchLoadAllVm>>(procVehicleDispatchs)
            };

            return vm;
        }
    }
}
