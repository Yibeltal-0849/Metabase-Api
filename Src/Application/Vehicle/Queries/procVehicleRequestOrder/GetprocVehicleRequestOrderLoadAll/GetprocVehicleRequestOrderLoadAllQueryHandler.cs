using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Queries.procVehicleRequestOrder.GetprocVehicleRequestOrderLoadAll
{
    class GetprocVehicleRequestOrderLoadAllQueryHandler : IRequestHandler<GetprocVehicleRequestOrderLoadAllQuery, GetprocVehicleRequestOrderLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocVehicleRequestOrderLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVehicleRequestOrderLoadAllListVm> Handle(GetprocVehicleRequestOrderLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<VehicleRequestOrder> procVehicleRequestOrders = await _procedureAdabter
               .Execute<VehicleRequestOrder>("[Vehicle].[proc_VehicleRequest_OrderLoadAll]");
            GetprocVehicleRequestOrderLoadAllListVm vm = new GetprocVehicleRequestOrderLoadAllListVm
            {
                procVehicleRequestOrders = _mapper.Map<IList<VehicleRequestOrder>, IList<GetprocVehicleRequestOrderLoadAllVm>>(procVehicleRequestOrders)
            };

            return vm;
        }
    }
}
