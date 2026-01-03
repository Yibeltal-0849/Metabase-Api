using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.FixedAssetEntrustTransaction.FixedAssetEntrustTransactionDelete.FixedAssetEntrustTransactionDeleteCommand
{

    /// @author  Shimels Alem  Fixed_Asset_Entrust_TransactionDelete stored procedure.


    public class FixedAssetEntrustTransactionDeleteHandler : IRequestHandler<FixedAssetEntrustTransactionDeleteCommand, IList<FixedAssetEntrustTransaction_Entrust_Trans_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetEntrustTransactionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetEntrustTransaction_Entrust_Trans_ID>> Handle( FixedAssetEntrustTransactionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetEntrustTransaction_Entrust_Trans_ID> result = await _procedureAdabter
                .Execute<FixedAssetEntrustTransaction_Entrust_Trans_ID>("[FixedAsset].Fixed_Asset_Entrust_TransactionDelete", request);
           

            return result;
        }
    }
}
  