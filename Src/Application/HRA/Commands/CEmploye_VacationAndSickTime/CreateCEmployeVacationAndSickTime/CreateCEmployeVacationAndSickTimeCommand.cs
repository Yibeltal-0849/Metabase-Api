using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.CEmploye_VacationAndSickTime;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.CEmploye_VacationAndSickTime.CreateCEmployeVacationAndSickTime
{

    /// @author  Shimels Alem  CreateCEmployeVacationAndSickTime stored procedure.
   
    public class CreateCEmployeVacationAndSickTimeCommand : GetCEmployeVacationAndSickTimeLoadAllVM, IRequest<IList<Proc_C_Employe_VacationAndSickTime_id>>
    {

    }
}
