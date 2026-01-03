



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.dbo;
using XOKA.Domain.Interfaces;


namespace Application.dbo.Commands.procContract.procContractInsert.procContractInsertCommand
{

    /// @author  Shimels Alem  proc_ContractInsert stored procedure.


    public class procContractInsertHandler : IRequestHandler<procContractInsertCommand, IList<Contract_ContractNo>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procContractInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Contract_ContractNo>> Handle( procContractInsertCommand request, CancellationToken cancellationToken)
        {

            IList<Contract_ContractNo> result = await _procedureAdabter
                .Execute<Contract_ContractNo>("[dbo].proc_ContractInsert", request);
           

            return result;
        }
    }
}
 