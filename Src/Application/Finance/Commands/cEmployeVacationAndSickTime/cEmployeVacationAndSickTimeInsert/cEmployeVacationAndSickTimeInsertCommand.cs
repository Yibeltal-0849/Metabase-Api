


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cEmployeVacationAndSickTime.cEmployeVacationAndSickTimeInsert.cEmployeVacationAndSickTimeInsertCommand
{

    /// @author  Shimels Alem  c_Employe_VacationAndSickTimeInsert stored procedure.


    public class cEmployeVacationAndSickTimeInsertCommand : IRequest<IList<CEmployeVacationAndSickTime_id>>
    {
        public long id { get; set; }
        public string Employee_Id { get; set; }
        public bool? UseDefault { get; set; }
        public long? EmplyeeGetHours { get; set; }
        public bool? Receives_at_Begining { get; set; }
        public long? MaxVacationOrSick_Time { get; set; }
    }
		
		
		 
	}
 
 