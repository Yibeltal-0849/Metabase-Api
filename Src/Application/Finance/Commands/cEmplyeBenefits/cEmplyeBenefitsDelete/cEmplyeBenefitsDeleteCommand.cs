 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cEmplyeBenefits.cEmplyeBenefitsDelete.cEmplyeBenefitsDeleteCommand
{

    // @author  Shimels Alem  c_Emplye_BenefitsDelete stored procedure.


    public class cEmplyeBenefitsDeleteCommand : IRequest<IList<CEmplyeBenefits_Name>>
    {

        public string Name { get; set; }
    }
		
     
		
		 
	}
 
 