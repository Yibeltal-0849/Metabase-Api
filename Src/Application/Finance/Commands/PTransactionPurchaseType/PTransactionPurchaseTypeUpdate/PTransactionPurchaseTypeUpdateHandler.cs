

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.PTransactionPurchaseType.PTransactionPurchaseTypeUpdate.PTransactionPurchaseTypeUpdateCommand
{

    /// @author  Shimels Alem  [P_Transaction Purchase TypeUpdate] stored procedure.


    public class PTransactionPurchaseTypeUpdateHandler : IRequestHandler<PTransactionPurchaseTypeUpdateCommand, IList<PTransactionPurchaseType_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PTransactionPurchaseTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PTransactionPurchaseType_Code>> Handle( PTransactionPurchaseTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<PTransactionPurchaseType_Code> result = await _procedureAdabter
                .Execute<PTransactionPurchaseType_Code>("[FINA].[P_Transaction Purchase TypeUpdate]", request);
           

            return result;
        }
    }
}
 