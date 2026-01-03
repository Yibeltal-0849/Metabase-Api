



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.CTransactionPurchase.CTransactionPurchaseInsert.CTransactionPurchaseInsertCommand
{

    /// @author  Shimels Alem  proc_CTransaction_Purchase_Insert stored procedure.


    public class CTransactionPurchaseInsertHandler : IRequestHandler<CTransactionPurchaseInsertCommand, IList<CTransactionPurchase_No>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CTransactionPurchaseInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTransactionPurchase_No>> Handle( CTransactionPurchaseInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CTransactionPurchase_No> result = await _procedureAdabter
                .Execute<CTransactionPurchase_No>("[FINA].[proc_CTransaction_PurchaseInsert]", request);
           

            return result;
        }
    }
}
 