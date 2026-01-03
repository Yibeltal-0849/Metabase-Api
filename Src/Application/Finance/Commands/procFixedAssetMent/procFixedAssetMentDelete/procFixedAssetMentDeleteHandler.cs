using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procFixedAssetMent.procFixedAssetMentDelete.procFixedAssetMentDeleteCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_MentDelete stored procedure.


    public class procFixedAssetMentDeleteHandler : IRequestHandler<procFixedAssetMentDeleteCommand, IList<FixedAssetMent_Maintainance_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetMentDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetMent_Maintainance_ID>> Handle( procFixedAssetMentDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetMent_Maintainance_ID> result = await _procedureAdabter
                .Execute<FixedAssetMent_Maintainance_ID>("[FINA].proc_Fixed_Asset_MentDelete", request);
           

            return result;
        }
    }
}
  