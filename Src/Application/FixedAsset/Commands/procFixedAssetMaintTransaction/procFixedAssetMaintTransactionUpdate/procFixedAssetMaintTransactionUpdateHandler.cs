

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;



namespace Application.FixedAsset.Commands.procFixedAssetMaintTransaction.procFixedAssetMaintTransactionUpdate.procFixedAssetMaintTransactionUpdateCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_Maint_TransactionUpdate stored procedure.


    public class procFixedAssetMaintTransactionUpdateHandler : IRequestHandler<procFixedAssetMaintTransactionUpdateCommand, IList<FixedAssetMaintTransaction_FixedAsset_Maintan_Trans_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetMaintTransactionUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetMaintTransaction_FixedAsset_Maintan_Trans_ID>> Handle( procFixedAssetMaintTransactionUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetMaintTransaction_FixedAsset_Maintan_Trans_ID> result = await _procedureAdabter
                .Execute<FixedAssetMaintTransaction_FixedAsset_Maintan_Trans_ID>("[FixedAsset].proc_Fixed_Asset_Maint_TransactionUpdate", request);
           

            return result;
        }
    }
}
 