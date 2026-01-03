



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procFixedAssetManagementTransaction.procFixedAssetManagementTransactionInsert.procFixedAssetManagementTransactionInsertCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_Management_TransactionInsert stored procedure.


    public class procFixedAssetManagementTransactionInsertHandler : IRequestHandler<procFixedAssetManagementTransactionInsertCommand, IList<FixedAssetManagementTransaction_FixedAsset_Trans_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetManagementTransactionInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetManagementTransaction_FixedAsset_Trans_ID>> Handle( procFixedAssetManagementTransactionInsertCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetManagementTransaction_FixedAsset_Trans_ID> result = await _procedureAdabter
                .Execute<FixedAssetManagementTransaction_FixedAsset_Trans_ID>("[FINA].proc_Fixed_Asset_Management_TransactionInsert", request);
           

            return result;
        }
    }
}
 