using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procFixedAssetManagementTransaction.procFixedAssetManagementTransactionDelete.procFixedAssetManagementTransactionDeleteCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_Management_TransactionDelete stored procedure.


    public class procFixedAssetManagementTransactionDeleteHandler : IRequestHandler<procFixedAssetManagementTransactionDeleteCommand, IList<FixedAssetManagementTransaction_FixedAsset_Trans_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetManagementTransactionDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetManagementTransaction_FixedAsset_Trans_ID>> Handle( procFixedAssetManagementTransactionDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetManagementTransaction_FixedAsset_Trans_ID> result = await _procedureAdabter
                .Execute<FixedAssetManagementTransaction_FixedAsset_Trans_ID>("[FINA].proc_Fixed_Asset_Management_TransactionDelete", request);
           

            return result;
        }
    }
}
  