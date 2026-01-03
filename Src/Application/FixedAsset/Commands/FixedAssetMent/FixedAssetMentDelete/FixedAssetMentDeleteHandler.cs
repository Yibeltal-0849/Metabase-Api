using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.FixedAssetMent.FixedAssetMentDelete.FixedAssetMentDeleteCommand
{

    /// @author  Shimels Alem  Fixed_Asset_MentDelete stored procedure.


    public class FixedAssetMentDeleteHandler : IRequestHandler<FixedAssetMentDeleteCommand, IList<FixedAssetMent_Maintainance_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetMentDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetMent_Maintainance_ID>> Handle( FixedAssetMentDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetMent_Maintainance_ID> result = await _procedureAdabter
                .Execute<FixedAssetMent_Maintainance_ID>("[FixedAsset].Fixed_Asset_MentDelete", request);
           

            return result;
        }
    }
}
  