using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cTurmsAndCredit.cTurmsAndCreditDelete.cTurmsAndCreditDeleteCommand
{

    /// @author  Shimels Alem  c_TurmsAndCreditDelete stored procedure.


    public class cTurmsAndCreditDeleteHandler : IRequestHandler<cTurmsAndCreditDeleteCommand, IList<CTurmsAndCredit_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cTurmsAndCreditDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTurmsAndCredit_Id>> Handle( cTurmsAndCreditDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CTurmsAndCredit_Id> result = await _procedureAdabter
                .Execute<CTurmsAndCredit_Id>("[FINA].c_TurmsAndCreditDelete", request);
           
            return result;
        }
    }
}
  