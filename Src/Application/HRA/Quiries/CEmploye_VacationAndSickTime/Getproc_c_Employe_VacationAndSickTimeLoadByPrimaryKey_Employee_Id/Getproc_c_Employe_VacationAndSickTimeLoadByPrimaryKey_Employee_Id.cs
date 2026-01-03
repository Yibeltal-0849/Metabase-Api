using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.CEmploye_VacationAndSickTime.GetCEmployeVacationAndSickTimeLoadAll;

namespace XOKA.Application.HRA.Quiries.CEmploye_VacationAndSickTime.Getproc_c_Employe_VacationAndSickTimeLoadByPrimaryKey_Employee_Id
{
    /// @author  Shimels Alem  proc_c_Employe_VacationAndSickTimeLoadByPrimaryKey_Employee_Id stored procedure.

    public class Getproc_c_Employe_VacationAndSickTimeLoadByPrimaryKey_Employee_Id : IRequest<GetCEmployeVacationAndSickTimeLoadAllListVm>
    {
        public string Employee_Id { get; set; }
    }
}
