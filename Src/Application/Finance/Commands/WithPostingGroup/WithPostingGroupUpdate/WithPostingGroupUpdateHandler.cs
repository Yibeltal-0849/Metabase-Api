

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.WithPostingGroup.WithPostingGroupUpdate.WithPostingGroupUpdateCommand
{

    /// @author  Shimels Alem  With_Posting_GroupUpdate stored procedure.


    public class WithPostingGroupUpdateHandler : IRequestHandler<WithPostingGroupUpdateCommand, IList<With_Posting_Group_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public WithPostingGroupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<With_Posting_Group_Code>> Handle( WithPostingGroupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<With_Posting_Group_Code> result = await _procedureAdabter
                .Execute<With_Posting_Group_Code>("[FINA].With_Posting_GroupUpdate", request);
           

            return result;
        }
    }
}
 