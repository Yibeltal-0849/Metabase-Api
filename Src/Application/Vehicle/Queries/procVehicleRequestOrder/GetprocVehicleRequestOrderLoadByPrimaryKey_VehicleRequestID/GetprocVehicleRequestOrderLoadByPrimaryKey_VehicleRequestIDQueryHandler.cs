using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Vehicle.Queries.procVehicleRequestOrder.GetprocVehicleRequestOrderLoadAll;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Queries.procVehicleRequestOrder.GetprocVehicleRequestOrderLoadByPrimaryKey_VehicleRequestID
{
    public class GetprocVehicleRequestOrderQueryHandler : IRequestHandler<GetprocVehicleRequestOrderLoadByPrimaryKey_VehicleRequestID, GetprocVehicleRequestOrderLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocVehicleRequestOrderQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVehicleRequestOrderLoadAllListVm> Handle(GetprocVehicleRequestOrderLoadByPrimaryKey_VehicleRequestID request, CancellationToken cancellationToken)
        {
           
            IList<VehicleRequestOrder> procVehicleRequestOrders = await _procedureAdabter
               .Execute<VehicleRequestOrder>("[Vehicle].[proc_VehicleRequest_OrderLoadByPrimaryKey_Vehicle_RequestID]", request);
            GetprocVehicleRequestOrderLoadAllListVm vm = new GetprocVehicleRequestOrderLoadAllListVm
            {
                procVehicleRequestOrders = _mapper.Map<IList<VehicleRequestOrder>, IList<GetprocVehicleRequestOrderLoadAllVm>>(procVehicleRequestOrders)
            };

            return vm;
        }
    }
}
