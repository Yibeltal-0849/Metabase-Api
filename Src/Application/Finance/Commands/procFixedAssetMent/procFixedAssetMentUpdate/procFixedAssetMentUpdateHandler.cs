

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.procFixedAssetMent.procFixedAssetMentUpdate.procFixedAssetMentUpdateCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_MentUpdate stored procedure.


    public class procFixedAssetMentUpdateHandler : IRequestHandler<procFixedAssetMentUpdateCommand, IList<FixedAssetMent_Maintainance_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetMentUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetMent_Maintainance_ID>> Handle( procFixedAssetMentUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetMent_Maintainance_ID> result = await _procedureAdabter
                .Execute<FixedAssetMent_Maintainance_ID>("[FINA].proc_Fixed_Asset_MentUpdate", request);
           

            return result;
        }
    }
}
 