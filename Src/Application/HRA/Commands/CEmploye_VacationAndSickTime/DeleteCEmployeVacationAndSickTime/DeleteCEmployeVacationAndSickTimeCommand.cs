using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.CEmploye_VacationAndSickTime.DeleteCEmployeVacationAndSickTime
{
    /// @author  Shimels Alem  DeleteCEmployeVacationAndSickTime stored procedure.
    
    public class DeleteCEmployeVacationAndSickTimeCommand : IRequest<IList<Proc_C_Employe_VacationAndSickTime_id>>
    {
        public long Id { get; set; }
    }
}