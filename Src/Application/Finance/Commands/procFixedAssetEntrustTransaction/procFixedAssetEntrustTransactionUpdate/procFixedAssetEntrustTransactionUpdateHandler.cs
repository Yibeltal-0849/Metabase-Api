

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.procFixedAssetEntrustTransaction.procFixedAssetEntrustTransactionUpdate.procFixedAssetEntrustTransactionUpdateCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_Entrust_TransactionUpdate stored procedure.


    public class procFixedAssetEntrustTransactionUpdateHandler : IRequestHandler<procFixedAssetEntrustTransactionUpdateCommand, IList<FixedAssetEntrustTransaction_EntrustTransID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetEntrustTransactionUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetEntrustTransaction_EntrustTransID>> Handle( procFixedAssetEntrustTransactionUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetEntrustTransaction_EntrustTransID> result = await _procedureAdabter
                .Execute<FixedAssetEntrustTransaction_EntrustTransID>("[FINA].proc_Fixed_Asset_Entrust_TransactionUpdate", request);
           

            return result;
        }
    }
}
 