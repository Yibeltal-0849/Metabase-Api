using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.procFixedAssetMaintTransaction.procFixedAssetMaintTransactionDelete.procFixedAssetMaintTransactionDeleteCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_Maint_TransactionDelete stored procedure.


    public class procFixedAssetMaintTransactionDeleteHandler : IRequestHandler<procFixedAssetMaintTransactionDeleteCommand, IList<FixedAssetMaintTransaction_FixedAsset_Maintan_Trans_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetMaintTransactionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetMaintTransaction_FixedAsset_Maintan_Trans_ID>> Handle( procFixedAssetMaintTransactionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetMaintTransaction_FixedAsset_Maintan_Trans_ID> result = await _procedureAdabter
                .Execute<FixedAssetMaintTransaction_FixedAsset_Maintan_Trans_ID>("[FixedAsset].proc_Fixed_Asset_Maint_TransactionDelete", request);
           

            return result;
        }
    }
}
  