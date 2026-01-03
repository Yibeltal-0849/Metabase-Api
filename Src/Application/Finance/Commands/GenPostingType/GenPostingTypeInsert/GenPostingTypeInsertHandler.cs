



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.GenPostingType.GenPostingTypeInsert.GenPostingTypeInsertCommand
{

    /// @author  Shimels Alem  Gen_Posting_TypeInsert stored procedure.


    public class GenPostingTypeInsertHandler : IRequestHandler<GenPostingTypeInsertCommand, IList<GenPostingType_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GenPostingTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<GenPostingType_Code>> Handle( GenPostingTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<GenPostingType_Code> result = await _procedureAdabter
                .Execute<GenPostingType_Code>("[FINA].Gen_Posting_TypeInsert", request);
           

            return result;
        }
    }
}
 