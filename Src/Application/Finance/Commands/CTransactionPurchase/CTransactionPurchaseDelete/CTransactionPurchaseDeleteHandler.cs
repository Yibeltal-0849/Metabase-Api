using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CTransactionPurchase.CTransactionPurchaseDelete.CTransactionPurchaseDeleteCommand
{

    /// @author  Shimels Alem  proc_CTransaction_PurchaseDelete stored procedure.


    public class CTransactionPurchaseDeleteHandler : IRequestHandler<CTransactionPurchaseDeleteCommand, IList<CTransactionPurchase_No>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CTransactionPurchaseDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTransactionPurchase_No>> Handle( CTransactionPurchaseDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CTransactionPurchase_No> result = await _procedureAdabter
                .Execute<CTransactionPurchase_No>("[FINA].proc_CTransaction_PurchaseDelete", request);
           

            return result;
        }
    }
}
  