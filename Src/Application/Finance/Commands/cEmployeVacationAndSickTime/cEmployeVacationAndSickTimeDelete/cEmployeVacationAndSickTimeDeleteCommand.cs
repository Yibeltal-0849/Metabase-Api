 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cEmployeVacationAndSickTime.cEmployeVacationAndSickTimeDelete.cEmployeVacationAndSickTimeDeleteCommand
{

    // @author  Shimels Alem  c_Employe_VacationAndSickTimeDelete stored procedure.


    public class cEmployeVacationAndSickTimeDeleteCommand : IRequest<IList<CEmployeVacationAndSickTime_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
	}
 
 