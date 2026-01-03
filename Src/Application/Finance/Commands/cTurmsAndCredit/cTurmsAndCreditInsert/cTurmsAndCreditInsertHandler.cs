



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cTurmsAndCredit.cTurmsAndCreditInsert.cTurmsAndCreditInsertCommand
{

    /// @author  Shimels Alem  c_TurmsAndCreditInsert stored procedure.


    public class cTurmsAndCreditInsertHandler : IRequestHandler<cTurmsAndCreditInsertCommand, IList<CTurmsAndCredit_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cTurmsAndCreditInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTurmsAndCredit_Id>> Handle( cTurmsAndCreditInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CTurmsAndCredit_Id> result = await _procedureAdabter
                .Execute<CTurmsAndCredit_Id>("[FINA].c_TurmsAndCreditInsert", request);
           

            return result;
        }
    }
}
 