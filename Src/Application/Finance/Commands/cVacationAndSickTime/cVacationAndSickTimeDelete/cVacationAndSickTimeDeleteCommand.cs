 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cVacationAndSickTime.cVacationAndSickTimeDelete.cVacationAndSickTimeDeleteCommand
{

    // @author  Shimels Alem  c_VacationAndSickTimeDelete stored procedure.


    public class cVacationAndSickTimeDeleteCommand : IRequest<IList<CVacationAndSickTime_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 