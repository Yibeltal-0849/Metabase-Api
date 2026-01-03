using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procFleetContract.procFleetContractDelete.procFleetContractDeleteCommand
{

    /// @author  Shimels Alem  proc_Fleet_ContractDelete stored procedure.


    public class procFleetContractDeleteHandler : IRequestHandler<procFleetContractDeleteCommand, IList<FleetContract_Contract_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFleetContractDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FleetContract_Contract_ID>> Handle( procFleetContractDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<FleetContract_Contract_ID> result = await _procedureAdabter
                .Execute<FleetContract_Contract_ID>("[FINA].proc_Fleet_ContractDelete", request);
           

            return result;
        }
    }
}
  