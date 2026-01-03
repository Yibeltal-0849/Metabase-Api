

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;



namespace Application.dbo.Commands.procContract.procContractUpdate.procContractUpdateCommand
{

    /// @author  Shimels Alem  proc_ContractUpdate stored procedure.


    public class procContractUpdateHandler : IRequestHandler<procContractUpdateCommand, IList<Contract_ContractNo>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procContractUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Contract_ContractNo>> Handle( procContractUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Contract_ContractNo> result = await _procedureAdabter
                .Execute<Contract_ContractNo>("[dbo].proc_ContractUpdate", request);
           

            return result;
        }
    }
}
 