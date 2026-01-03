using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.proccEmployeVacationAndSickTime.GetproccEmployeVacationAndSickTimeLoadAll;

namespace Application.Finance.Quiries.proccEmployeVacationAndSickTime.GetproccEmployeVacationAndSickTimeByPrimaryKey
{
    /// @author  Shimels Alem proc_c_Employe_VacationAndSickTimeLoadByPrimaryKey stored procedure.

    public class GetproccEmployeVacationAndSickTimeByPrimaryKey : IRequest<GetproccEmployeVacationAndSickTimeLoadAllListVm>
    {
        public long id { get; set; }
    }
}
