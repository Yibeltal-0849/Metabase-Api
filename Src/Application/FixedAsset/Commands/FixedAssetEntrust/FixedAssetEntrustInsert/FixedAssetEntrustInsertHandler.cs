



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;


namespace Application.FixedAsset.Commands.FixedAssetEntrust.FixedAssetEntrustInsert.FixedAssetEntrustInsertCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_EntrustInsert stored procedure.


    public class FixedAssetEntrustInsertHandler : IRequestHandler<FixedAssetEntrustInsertCommand, IList<FixedAssetEntrust_Entrust_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetEntrustInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetEntrust_Entrust_ID>> Handle( FixedAssetEntrustInsertCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetEntrust_Entrust_ID> result = await _procedureAdabter
                .Execute<FixedAssetEntrust_Entrust_ID>("[FixedAsset].proc_Fixed_Asset_EntrustInsert", request);
           

            return result;
        }
    }
}
 