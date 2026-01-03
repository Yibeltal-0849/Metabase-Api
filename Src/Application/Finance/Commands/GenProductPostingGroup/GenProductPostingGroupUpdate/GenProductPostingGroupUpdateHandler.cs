

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.GenProductPostingGroup.GenProductPostingGroupUpdate.GenProductPostingGroupUpdateCommand
{

    /// @author  Shimels Alem  Gen_Product_Posting_GroupUpdate stored procedure.


    public class GenProductPostingGroupUpdateHandler : IRequestHandler<GenProductPostingGroupUpdateCommand, IList<GenProductPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GenProductPostingGroupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<GenProductPostingGroup_Code>> Handle( GenProductPostingGroupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<GenProductPostingGroup_Code> result = await _procedureAdabter
                .Execute<GenProductPostingGroup_Code>("[FINA].Gen_Product_Posting_GroupUpdate", request);
           

            return result;
        }
    }
}
 