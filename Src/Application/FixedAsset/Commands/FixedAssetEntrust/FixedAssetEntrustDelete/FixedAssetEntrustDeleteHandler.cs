using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.FixedAssetEntrust.FixedAssetEntrustDelete.FixedAssetEntrustDeleteCommand
{

    /// @author  Shimels Alem  Fixed_Asset_EntrustDelete stored procedure.


    public class FixedAssetEntrustDeleteHandler : IRequestHandler<FixedAssetEntrustDeleteCommand, IList<FixedAssetEntrust_Entrust_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetEntrustDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetEntrust_Entrust_ID>> Handle( FixedAssetEntrustDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetEntrust_Entrust_ID> result = await _procedureAdabter
                .Execute<FixedAssetEntrust_Entrust_ID>("[FixedAsset].Fixed_Asset_EntrustDelete", request);
           

            return result;
        }
    }
}
  