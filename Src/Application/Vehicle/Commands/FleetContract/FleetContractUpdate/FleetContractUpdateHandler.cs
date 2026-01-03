using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.FleetContract.FleetContractUpdate.FleetContractUpdateCommand
{ 

      public class FleetContractUpdateHandler : IRequestHandler<FleetContractUpdateCommand, IList<FleetContract_Contract_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FleetContractUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FleetContract_Contract_ID>> Handle( FleetContractUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FleetContract_Contract_ID> result = await _procedureAdabter
                .Execute<FleetContract_Contract_ID>("[Vehicle].proc_Fleet_ContractUpdate", request);
           

            return result;
        }
    }
}
 
