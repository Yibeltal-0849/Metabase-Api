using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.GenPostingType.GenPostingTypeDelete.GenPostingTypeDeleteCommand
{

    /// @author  Shimels Alem  Gen_Posting_TypeDelete stored procedure.


    public class GenPostingTypeDeleteHandler : IRequestHandler<GenPostingTypeDeleteCommand, IList<GenPostingType_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GenPostingTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<GenPostingType_Code>> Handle( GenPostingTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<GenPostingType_Code> result = await _procedureAdabter
                .Execute<GenPostingType_Code>("[FINA].Gen_Posting_TypeDelete", request);
           

            return result;
        }
    }
}
  