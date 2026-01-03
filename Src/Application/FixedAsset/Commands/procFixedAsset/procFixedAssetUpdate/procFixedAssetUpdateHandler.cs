

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;



namespace Application.FixedAsset.Commands.procFixedAsset.procFixedAssetUpdate.procFixedAssetUpdateCommand
{

    /// @author  Shimels Alem  proc_Fixed_AssetUpdate stored procedure.


    public class procFixedAssetUpdateHandler : IRequestHandler<procFixedAssetUpdateCommand, IList<FixedAsset_FIXED_Asset_No>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAsset_FIXED_Asset_No>> Handle( procFixedAssetUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAsset_FIXED_Asset_No> result = await _procedureAdabter
                .Execute<FixedAsset_FIXED_Asset_No>("[FixedAsset].proc_Fixed_AssetUpdate", request);
           

            return result;
        }
    }
}
 