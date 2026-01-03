

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.procFleetContract.procFleetContractUpdate.procFleetContractUpdateCommand
{

    /// @author  Shimels Alem  proc_Fleet_ContractUpdate stored procedure.


    public class procFleetContractUpdateHandler : IRequestHandler<procFleetContractUpdateCommand, IList<FleetContract_Contract_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFleetContractUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FleetContract_Contract_ID>> Handle( procFleetContractUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FleetContract_Contract_ID> result = await _procedureAdabter
                .Execute<FleetContract_Contract_ID>("[FINA].proc_Fleet_ContractUpdate", request);
           

            return result;
        }
    }
}
 