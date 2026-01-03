

using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;



namespace Application.Purchase.Commands.procPerchaseContract.procPerchaseContractUpdate.procPerchaseContractUpdateCommand
{

    /// @author  Shimels Alem  proc_Perchase_ContractUpdate stored procedure.


    public class procPerchaseContractUpdateHandler : IRequestHandler<procPerchaseContractUpdateCommand, IList<Perchase_Contract_Purchase_Contract>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPerchaseContractUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Perchase_Contract_Purchase_Contract>> Handle( procPerchaseContractUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Perchase_Contract_Purchase_Contract> result = await _procedureAdabter
                .Execute<Perchase_Contract_Purchase_Contract>("[Purchase].proc_Perchase_ContractUpdate", request);
           

            return result;
        }
    }
}
 