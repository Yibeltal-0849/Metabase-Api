using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleDispatch.VehicleDispatchDelete.VehicleDispatchDeleteCommand
{ 	 
	 
      public class VehicleDispatchDeleteHandler : IRequestHandler<VehicleDispatchDeleteCommand, IList<VehicleDispatch_Vehicle_DispatchID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VehicleDispatchDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VehicleDispatch_Vehicle_DispatchID>> Handle( VehicleDispatchDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<VehicleDispatch_Vehicle_DispatchID> result = await _procedureAdabter
                .Execute<VehicleDispatch_Vehicle_DispatchID>("[Vehicle].Vehicle_DispatchDelete", request);
           

            return result;
        }
    }
}
 
