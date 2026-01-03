using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleDispatch.VehicleDispatchUpdate.VehicleDispatchUpdateCommand
{ 

      public class VehicleDispatchUpdateHandler : IRequestHandler<VehicleDispatchUpdateCommand, IList<VehicleDispatch_Vehicle_DispatchID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VehicleDispatchUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VehicleDispatch_Vehicle_DispatchID>> Handle( VehicleDispatchUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<VehicleDispatch_Vehicle_DispatchID> result = await _procedureAdabter
                .Execute<VehicleDispatch_Vehicle_DispatchID>("[Vehicle].Vehicle_DispatchUpdate", request);
           

            return result;
        }
    }
}
 
