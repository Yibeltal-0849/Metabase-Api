



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.procRentContract.procRentContractInsert.procRentContractInsertCommand
{

    /// @author  Shimels Alem  proc_Rent_ContractInsert stored procedure.


    public class procRentContractInsertHandler : IRequestHandler<procRentContractInsertCommand, IList<RentContract_Rent_Contract_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procRentContractInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<RentContract_Rent_Contract_ID>> Handle( procRentContractInsertCommand request, CancellationToken cancellationToken)
        {

            IList<RentContract_Rent_Contract_ID> result = await _procedureAdabter
                .Execute<RentContract_Rent_Contract_ID>("[ProprtyData].proc_Rent_ContractInsert", request);
           

            return result;
        }
    }
}
 