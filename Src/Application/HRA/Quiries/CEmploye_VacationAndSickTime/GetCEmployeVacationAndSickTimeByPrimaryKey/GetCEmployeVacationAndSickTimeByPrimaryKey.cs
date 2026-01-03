using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.CEmploye_VacationAndSickTime.GetCEmployeVacationAndSickTimeLoadAll;

namespace XOKA.Application.HRA.Quiries.CEmploye_VacationAndSickTime.GetCEmployeVacationAndSickTimeByPrimaryKey
{
    /// @author  Shimels Alem  GetCEmployeVacationAndSickTimeByPrimaryKey stored procedure.
    
    public class GetCEmployeVacationAndSickTimeByPrimaryKey : IRequest<GetCEmployeVacationAndSickTimeLoadAllListVm>
    {
        public long Id { get; set; }
    }
}
