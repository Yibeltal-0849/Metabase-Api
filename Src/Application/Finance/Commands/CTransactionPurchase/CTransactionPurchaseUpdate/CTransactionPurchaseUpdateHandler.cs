

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.CTransactionPurchase.CTransactionPurchaseUpdate.CTransactionPurchaseUpdateCommand
{

    /// @author  Shimels Alem  proc_CTransaction_PurchaseUpdate stored procedure.


    public class CTransactionPurchaseUpdateHandler : IRequestHandler<CTransactionPurchaseUpdateCommand, IList<CTransactionPurchase_No>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CTransactionPurchaseUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTransactionPurchase_No>> Handle( CTransactionPurchaseUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CTransactionPurchase_No> result = await _procedureAdabter
                .Execute<CTransactionPurchase_No>("[FINA].proc_CTransaction_PurchaseUpdate", request);
           

            return result;
        }
    }
}
 