using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.procRentContract.procRentContractDelete.procRentContractDeleteCommand
{

    /// @author  Shimels Alem  proc_Rent_ContractDelete stored procedure.


    public class procRentContractDeleteHandler : IRequestHandler<procRentContractDeleteCommand, IList<RentContract_Rent_Contract_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procRentContractDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<RentContract_Rent_Contract_ID>> Handle( procRentContractDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<RentContract_Rent_Contract_ID> result = await _procedureAdabter
                .Execute<RentContract_Rent_Contract_ID>("[ProprtyData].proc_Rent_ContractDelete", request);
           

            return result;
        }
    }
}
  