using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CJournalType.CJournalTypeDelete.CJournalTypeDeleteCommand
{

    /// @author  Shimels Alem  C_Journal_TypeDelete stored procedure.


    public class CJournalTypeDeleteHandler : IRequestHandler<CJournalTypeDeleteCommand, IList<CJournalType_Type>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CJournalTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CJournalType_Type>> Handle( CJournalTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CJournalType_Type> result = await _procedureAdabter
                .Execute<CJournalType_Type>("[FINA].C_Journal_TypeDelete", request);
           

            return result;
        }
    }
}
  