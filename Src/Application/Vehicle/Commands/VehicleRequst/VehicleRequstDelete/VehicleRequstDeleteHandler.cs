using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleRequst.VehicleRequstDelete.VehicleRequstDeleteCommand
{ 	 
	 
      public class VehicleRequstDeleteHandler : IRequestHandler<VehicleRequstDeleteCommand, IList<VehicleRequst_Vehicle_RequestID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public VehicleRequstDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<VehicleRequst_Vehicle_RequestID>> Handle( VehicleRequstDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<VehicleRequst_Vehicle_RequestID> result = await _procedureAdabter
                .Execute<VehicleRequst_Vehicle_RequestID>("[Vehicle].proc_Vehicle_RequstDelete", request);
           

            return result;
        }
    }
}
 
