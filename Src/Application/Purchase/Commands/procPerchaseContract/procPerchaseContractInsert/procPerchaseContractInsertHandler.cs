



using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;


namespace Application.Purchase.Commands.procPerchaseContract.procPerchaseContractInsert.procPerchaseContractInsertCommand
{

    /// @author  Shimels Alem  proc_Perchase_ContractInsert stored procedure.


    public class procPerchaseContractInsertHandler : IRequestHandler<procPerchaseContractInsertCommand, IList<Perchase_Contract_Purchase_Contract>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPerchaseContractInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Perchase_Contract_Purchase_Contract>> Handle( procPerchaseContractInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Perchase_Contract_Purchase_Contract> result = await _procedureAdabter
                .Execute<Perchase_Contract_Purchase_Contract>("[Purchase].proc_Perchase_ContractInsert", request);
           

            return result;
        }
    }
}
 