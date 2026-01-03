

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.GeneralPostingSetups.GeneralPostingSetupsUpdate.GeneralPostingSetupsUpdateCommand
{

    /// @author  Shimels Alem  General_Posting_SetupsUpdate stored procedure.


    public class GeneralPostingSetupsUpdateHandler : IRequestHandler<GeneralPostingSetupsUpdateCommand, IList<GeneralPostingSetups2_Gen_Bus_Posting_Group>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GeneralPostingSetupsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<GeneralPostingSetups2_Gen_Bus_Posting_Group>> Handle( GeneralPostingSetupsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<GeneralPostingSetups2_Gen_Bus_Posting_Group> result = await _procedureAdabter
                .Execute<GeneralPostingSetups2_Gen_Bus_Posting_Group>("[FINA].General_Posting_SetupsUpdate", request);
           

            return result;
        }
    }
}
 