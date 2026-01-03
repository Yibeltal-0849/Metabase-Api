

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.RentCollectionRequestFromBank.RentCollectionRequestFromBankUpdate.RentCollectionRequestFromBankUpdateCommand
{

    /// @author  Shimels Alem  C_Currency_IDUpdate stored procedure.


    public class RentCollectionRequestFromBankUpdateHandler : IRequestHandler<RentCollectionRequestFromBankUpdateCommand, IList<RentCollectionRequestFromBankID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public RentCollectionRequestFromBankUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<RentCollectionRequestFromBankID>> Handle( RentCollectionRequestFromBankUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<RentCollectionRequestFromBankID> result = await _procedureAdabter
                .Execute<RentCollectionRequestFromBankID>("[FINA].[proc_Rent_Collection_Request_From_BankUpdate]", request);
           

            return result;
        }
    }
}
 