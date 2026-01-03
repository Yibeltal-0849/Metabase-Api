using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cEmployeVacationAndSickTime.cEmployeVacationAndSickTimeDelete.cEmployeVacationAndSickTimeDeleteCommand
{

    /// @author  Shimels Alem  c_Employe_VacationAndSickTimeDelete stored procedure.


    public class cEmployeVacationAndSickTimeDeleteHandler : IRequestHandler<cEmployeVacationAndSickTimeDeleteCommand, IList<CEmployeVacationAndSickTime_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cEmployeVacationAndSickTimeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CEmployeVacationAndSickTime_id>> Handle( cEmployeVacationAndSickTimeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CEmployeVacationAndSickTime_id> result = await _procedureAdabter
                .Execute<CEmployeVacationAndSickTime_id>("[FINA].c_Employe_VacationAndSickTimeDelete", request);
           

            return result;
        }
    }
}
  