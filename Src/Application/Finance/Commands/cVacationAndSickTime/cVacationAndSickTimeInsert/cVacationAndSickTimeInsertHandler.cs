



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cVacationAndSickTime.cVacationAndSickTimeInsert.cVacationAndSickTimeInsertCommand
{

    /// @author  Shimels Alem  c_VacationAndSickTimeInsert stored procedure.


    public class cVacationAndSickTimeInsertHandler : IRequestHandler<cVacationAndSickTimeInsertCommand, IList<CVacationAndSickTime_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cVacationAndSickTimeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CVacationAndSickTime_id>> Handle( cVacationAndSickTimeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CVacationAndSickTime_id> result = await _procedureAdabter
                .Execute<CVacationAndSickTime_id>("[FINA].c_VacationAndSickTimeInsert", request);
           

            return result;
        }
    }
}
 