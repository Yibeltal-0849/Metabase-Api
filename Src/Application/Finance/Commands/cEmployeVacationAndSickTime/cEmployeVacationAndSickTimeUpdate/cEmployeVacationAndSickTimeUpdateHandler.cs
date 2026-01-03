

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cEmployeVacationAndSickTime.cEmployeVacationAndSickTimeUpdate.cEmployeVacationAndSickTimeUpdateCommand
{

    /// @author  Shimels Alem  c_Employe_VacationAndSickTimeUpdate stored procedure.


    public class cEmployeVacationAndSickTimeUpdateHandler : IRequestHandler<cEmployeVacationAndSickTimeUpdateCommand, IList<CEmployeVacationAndSickTime_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cEmployeVacationAndSickTimeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CEmployeVacationAndSickTime_id>> Handle( cEmployeVacationAndSickTimeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CEmployeVacationAndSickTime_id> result = await _procedureAdabter
                .Execute<CEmployeVacationAndSickTime_id>("[FINA].c_Employe_VacationAndSickTimeUpdate", request);
           

            return result;
        }
    }
}
 