 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cEmployeePayInfo.cEmployeePayInfoDelete.cEmployeePayInfoDeleteCommand
{

    // @author  Shimels Alem  c_EmployeePayInfoDelete stored procedure.


    public class cEmployeePayInfoDeleteCommand : IRequest<IList<CEmployeePayInfo_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
	}
 
 