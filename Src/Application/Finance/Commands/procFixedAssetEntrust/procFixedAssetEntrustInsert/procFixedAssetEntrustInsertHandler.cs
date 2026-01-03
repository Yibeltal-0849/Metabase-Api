



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procFixedAssetEntrust.procFixedAssetEntrustInsert.procFixedAssetEntrustInsertCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_EntrustInsert stored procedure.


    public class procFixedAssetEntrustInsertHandler : IRequestHandler<procFixedAssetEntrustInsertCommand, IList<FixedAssetEntrust_Entrust_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetEntrustInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetEntrust_Entrust_ID>> Handle( procFixedAssetEntrustInsertCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetEntrust_Entrust_ID> result = await _procedureAdabter
                .Execute<FixedAssetEntrust_Entrust_ID>("[FINA].proc_Fixed_Asset_EntrustInsert", request);
           

            return result;
        }
    }
}
 