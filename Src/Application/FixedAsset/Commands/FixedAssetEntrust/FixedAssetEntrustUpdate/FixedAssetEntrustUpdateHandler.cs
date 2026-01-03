

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.FixedAssetEntrust.FixedAssetEntrustUpdate.FixedAssetEntrustUpdateCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_EntrustUpdate stored procedure.


    public class FixedAssetEntrustUpdateHandler : IRequestHandler<FixedAssetEntrustUpdateCommand, IList<FixedAssetEntrust_Entrust_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetEntrustUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetEntrust_Entrust_ID>> Handle( FixedAssetEntrustUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetEntrust_Entrust_ID> result = await _procedureAdabter
                .Execute<FixedAssetEntrust_Entrust_ID>("[FixedAsset].proc_Fixed_Asset_EntrustUpdate", request);
           

            return result;
        }
    }
}
 