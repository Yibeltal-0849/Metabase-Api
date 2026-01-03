using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.HRA.Commands.CEmploye_VacationAndSickTime.UpdateCEmployeVacationAndSickTime
{
    public class UpdateCEmployeVacationAndSickTimeHandler : IRequestHandler<UpdateCEmployeVacationAndSickTimeCommand, IList<Proc_C_Employe_VacationAndSickTime_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateCEmployeVacationAndSickTimeHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Employe_VacationAndSickTime_id>> Handle(UpdateCEmployeVacationAndSickTimeCommand request, CancellationToken cancellationToken)
        {
            long? id = request.id;
            string Employee_Id = request.Employee_Id;
            bool? UseDefault = request.UseDefault;
            long? EmplyeeGetHours = request.EmplyeeGetHours;
            bool? Receives_at_Begining = request.Receives_At_Begining;
            long? MaxVacationOrSick_Time = request.MaxVacationOrSick_Time;

            IList<Proc_C_Employe_VacationAndSickTime_id> result = await _procedureAdabter
                .Execute<Proc_C_Employe_VacationAndSickTime_id>("[HRA].[proc_c_Employe_VacationAndSickTimeUpdate]",
                (nameof(id), id), 
                (nameof(Employee_Id), Employee_Id),
                (nameof(UseDefault), UseDefault),
                (nameof(EmplyeeGetHours), EmplyeeGetHours),
                (nameof(Receives_at_Begining), Receives_at_Begining),
                (nameof(MaxVacationOrSick_Time), MaxVacationOrSick_Time));

            return result;
        }
    }
}
