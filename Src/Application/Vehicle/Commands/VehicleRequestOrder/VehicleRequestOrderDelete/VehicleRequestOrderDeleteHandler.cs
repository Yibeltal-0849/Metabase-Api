using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleRequestOrder.VehicleRequestOrderDelete.VehicleRequestOrderDeleteCommand
{ 	 
	 
      public class VehicleRequestOrderDeleteHandler : IRequestHandler<VehicleRequestOrderDeleteCommand, IList<VehicleRequestOrder_Vehicle_OrderID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VehicleRequestOrderDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VehicleRequestOrder_Vehicle_OrderID>> Handle( VehicleRequestOrderDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<VehicleRequestOrder_Vehicle_OrderID> result = await _procedureAdabter
                .Execute<VehicleRequestOrder_Vehicle_OrderID>("[Vehicle].VehicleRequest_OrderDelete", request);
           

            return result;
        }
    }
}
 
