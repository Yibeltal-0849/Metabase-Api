



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.RentCollectionRequestFromBank.RentCollectionRequestFromBankInsert.RentCollectionRequestFromBankInsertCommand
{

    /// @author  Shimels Alem  C_Currency_IDInsert stored procedure.


    public class RentCollectionRequestFromBankInsertHandler : IRequestHandler<RentCollectionRequestFromBankInsertCommand, IList<RentCollectionRequestFromBankID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public RentCollectionRequestFromBankInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<RentCollectionRequestFromBankID>> Handle( RentCollectionRequestFromBankInsertCommand request, CancellationToken cancellationToken)
        {

            IList<RentCollectionRequestFromBankID> result = await _procedureAdabter
                .Execute<RentCollectionRequestFromBankID>("[FINA].[proc_Rent_Collection_Request_From_BankInsert]", request);
           

            return result;
        }
    }
}
 