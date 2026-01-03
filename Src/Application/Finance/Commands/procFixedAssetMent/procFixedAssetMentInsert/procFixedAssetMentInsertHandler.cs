



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procFixedAssetMent.procFixedAssetMentInsert.procFixedAssetMentInsertCommand
{

    /// @author  Shimels Alem  proc_Fixed_Asset_MentInsert stored procedure.


    public class procFixedAssetMentInsertHandler : IRequestHandler<procFixedAssetMentInsertCommand, IList<FixedAssetMent_Maintainance_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetMentInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetMent_Maintainance_ID>> Handle( procFixedAssetMentInsertCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetMent_Maintainance_ID> result = await _procedureAdabter
                .Execute<FixedAssetMent_Maintainance_ID>("[FINA].proc_Fixed_Asset_MentInsert", request);
           

            return result;
        }
    }
}
 