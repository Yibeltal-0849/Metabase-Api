

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.FixedAssetEntrustTransaction.FixedAssetEntrustTransactionUpdate.FixedAssetEntrustTransactionUpdateCommand
{

    /// @author  Shimels Alem  Fixed_Asset_Entrust_TransactionUpdate stored procedure.


    public class FixedAssetEntrustTransactionUpdateHandler : IRequestHandler<FixedAssetEntrustTransactionUpdateCommand, IList<FixedAssetEntrustTransaction_Entrust_Trans_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetEntrustTransactionUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetEntrustTransaction_Entrust_Trans_ID>> Handle( FixedAssetEntrustTransactionUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetEntrustTransaction_Entrust_Trans_ID> result = await _procedureAdabter
                .Execute<FixedAssetEntrustTransaction_Entrust_Trans_ID>("[FixedAsset].Fixed_Asset_Entrust_TransactionUpdate", request);
           

            return result;
        }
    }
}
 