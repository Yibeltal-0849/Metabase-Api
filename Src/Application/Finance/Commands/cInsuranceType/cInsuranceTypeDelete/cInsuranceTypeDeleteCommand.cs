 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cInsuranceType.cInsuranceTypeDelete.cInsuranceTypeDeleteCommand
{

    // @author  Shimels Alem  c_InsuranceTypeDelete stored procedure.


    public class cInsuranceTypeDeleteCommand : IRequest<IList<CInsuranceType_Name>>
    {
        public string Name { get; set; }
    }
		
     
		
		 
	}
 
 