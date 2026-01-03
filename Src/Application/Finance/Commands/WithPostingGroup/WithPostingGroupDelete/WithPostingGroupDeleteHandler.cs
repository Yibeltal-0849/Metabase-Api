using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.WithPostingGroup.WithPostingGroupDelete.WithPostingGroupDeleteCommand
{

    /// @author  Shimels Alem  With_Posting_GroupDelete stored procedure.


    public class WithPostingGroupDeleteHandler : IRequestHandler<WithPostingGroupDeleteCommand, IList<With_Posting_Group_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public WithPostingGroupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<With_Posting_Group_Code>> Handle( WithPostingGroupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<With_Posting_Group_Code> result = await _procedureAdabter
                .Execute<With_Posting_Group_Code>("[FINA].With_Posting_GroupDelete", request);
           

            return result;
        }
    }
}
  