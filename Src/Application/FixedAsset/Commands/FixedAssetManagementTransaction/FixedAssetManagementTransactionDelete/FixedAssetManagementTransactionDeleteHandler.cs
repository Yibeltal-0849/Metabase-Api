using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.FixedAssetManagementTransaction.FixedAssetManagementTransactionDelete.FixedAssetManagementTransactionDeleteCommand
{

    /// @author  Shimels Alem  Fixed_Asset_Management_TransactionDelete stored procedure.


    public class FixedAssetManagementTransactionDeleteHandler : IRequestHandler<FixedAssetManagementTransactionDeleteCommand, IList<FixedAssetManagementTransaction_FixedAsset_Trans_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetManagementTransactionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetManagementTransaction_FixedAsset_Trans_ID>> Handle( FixedAssetManagementTransactionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetManagementTransaction_FixedAsset_Trans_ID> result = await _procedureAdabter
                .Execute<FixedAssetManagementTransaction_FixedAsset_Trans_ID>("[FixedAsset].Fixed_Asset_Management_TransactionDelete", request);
           

            return result;
        }
    }
}
  