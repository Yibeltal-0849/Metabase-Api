



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;


namespace Application.FixedAsset.Commands.FixedAssetMent.FixedAssetMentInsert.FixedAssetMentInsertCommand
{

    /// @author  Shimels Alem  Fixed_Asset_MentInsert stored procedure.


    public class FixedAssetMentInsertHandler : IRequestHandler<FixedAssetMentInsertCommand, IList<FixedAssetMent_Maintainance_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetMentInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetMent_Maintainance_ID>> Handle( FixedAssetMentInsertCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetMent_Maintainance_ID> result = await _procedureAdabter
                .Execute<FixedAssetMent_Maintainance_ID>("[FixedAsset].Fixed_Asset_MentInsert", request);
           

            return result;
        }
    }
}
 