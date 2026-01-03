using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cVacationAndSickTime.cVacationAndSickTimeDelete.cVacationAndSickTimeDeleteCommand
{

    /// @author  Shimels Alem  c_VacationAndSickTimeDelete stored procedure.


    public class cVacationAndSickTimeDeleteHandler : IRequestHandler<cVacationAndSickTimeDeleteCommand, IList<CVacationAndSickTime_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cVacationAndSickTimeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CVacationAndSickTime_id>> Handle( cVacationAndSickTimeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CVacationAndSickTime_id> result = await _procedureAdabter
                .Execute<CVacationAndSickTime_id>("[FINA].c_VacationAndSickTimeDelete", request);
           

            return result;
        }
    }
}
  