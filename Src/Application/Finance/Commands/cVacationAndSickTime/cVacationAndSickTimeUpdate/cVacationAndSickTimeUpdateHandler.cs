

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cVacationAndSickTime.cVacationAndSickTimeUpdate.cVacationAndSickTimeUpdateCommand
{

    /// @author  Shimels Alem  c_VacationAndSickTimeUpdate stored procedure.


    public class cVacationAndSickTimeUpdateHandler : IRequestHandler<cVacationAndSickTimeUpdateCommand, IList<CVacationAndSickTime_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cVacationAndSickTimeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CVacationAndSickTime_id>> Handle( cVacationAndSickTimeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CVacationAndSickTime_id> result = await _procedureAdabter
                .Execute<CVacationAndSickTime_id>("[FINA].c_VacationAndSickTimeUpdate", request);
           

            return result;
        }
    }
}
 