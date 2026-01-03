

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cTurmsAndCredit.cTurmsAndCreditUpdate.cTurmsAndCreditUpdateCommand
{

    /// @author  Shimels Alem  c_TurmsAndCreditUpdate stored procedure.


    public class cTurmsAndCreditUpdateHandler : IRequestHandler<cTurmsAndCreditUpdateCommand, IList<CTurmsAndCredit_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cTurmsAndCreditUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTurmsAndCredit_Id>> Handle( cTurmsAndCreditUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CTurmsAndCredit_Id> result = await _procedureAdabter
                .Execute<CTurmsAndCredit_Id>("[FINA].c_TurmsAndCreditUpdate", request);
           

            return result;
        }
    }
}
 