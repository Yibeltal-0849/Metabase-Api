using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.GenProductPostingGroup.GenProductPostingGroupDelete.GenProductPostingGroupDeleteCommand
{

    /// @author  Shimels Alem  Gen_Product_Posting_GroupDelete stored procedure.


    public class GenProductPostingGroupDeleteHandler : IRequestHandler<GenProductPostingGroupDeleteCommand, IList<GenProductPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GenProductPostingGroupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<GenProductPostingGroup_Code>> Handle( GenProductPostingGroupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<GenProductPostingGroup_Code> result = await _procedureAdabter
                .Execute<GenProductPostingGroup_Code>("[FINA].Gen_Product_Posting_GroupDelete", request);
           

            return result;
        }
    }
}
  