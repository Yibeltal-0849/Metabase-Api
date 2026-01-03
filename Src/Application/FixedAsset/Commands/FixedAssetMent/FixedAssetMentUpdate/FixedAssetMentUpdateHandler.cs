

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.FixedAssetMent.FixedAssetMentUpdate.FixedAssetMentUpdateCommand
{

    /// @author  Shimels Alem  Fixed_Asset_MentUpdate stored procedure.


    public class FixedAssetMentUpdateHandler : IRequestHandler<FixedAssetMentUpdateCommand, IList<FixedAssetMent_Maintainance_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetMentUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetMent_Maintainance_ID>> Handle( FixedAssetMentUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetMent_Maintainance_ID> result = await _procedureAdabter
                .Execute<FixedAssetMent_Maintainance_ID>("[FixedAsset].Fixed_Asset_MentUpdate", request);
           
            return result;
        }
    }
}
 