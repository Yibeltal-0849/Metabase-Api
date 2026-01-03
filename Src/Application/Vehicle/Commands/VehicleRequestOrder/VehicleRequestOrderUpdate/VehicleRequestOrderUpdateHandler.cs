using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleRequestOrder.VehicleRequestOrderUpdate.VehicleRequestOrderUpdateCommand
{ 

      public class VehicleRequestOrderUpdateHandler : IRequestHandler<VehicleRequestOrderUpdateCommand, IList<VehicleRequestOrder_Vehicle_OrderID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VehicleRequestOrderUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VehicleRequestOrder_Vehicle_OrderID>> Handle( VehicleRequestOrderUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<VehicleRequestOrder_Vehicle_OrderID> result = await _procedureAdabter
                .Execute<VehicleRequestOrder_Vehicle_OrderID>("[Vehicle].VehicleRequest_OrderUpdate", request);
           

            return result;
        }
    }
}
 
