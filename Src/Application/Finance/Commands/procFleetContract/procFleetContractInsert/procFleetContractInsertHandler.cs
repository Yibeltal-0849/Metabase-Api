



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procFleetContract.procFleetContractInsert.procFleetContractInsertCommand
{

    /// @author  Shimels Alem  proc_Fleet_ContractInsert stored procedure.


    public class procFleetContractInsertHandler : IRequestHandler<procFleetContractInsertCommand, IList<FleetContract_Contract_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFleetContractInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FleetContract_Contract_ID>> Handle( procFleetContractInsertCommand request, CancellationToken cancellationToken)
        {

            IList<FleetContract_Contract_ID> result = await _procedureAdabter
                .Execute<FleetContract_Contract_ID>("[FINA].proc_Fleet_ContractInsert", request);
           

            return result;
        }
    }
}
 