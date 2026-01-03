 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cInsurancePlan.cInsurancePlanDelete.cInsurancePlanDeleteCommand
{

    // @author  Shimels Alem  c_InsurancePlanDelete stored procedure.


    public class cInsurancePlanDeleteCommand : IRequest<IList<CInsurancePlan_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
	}
 
 