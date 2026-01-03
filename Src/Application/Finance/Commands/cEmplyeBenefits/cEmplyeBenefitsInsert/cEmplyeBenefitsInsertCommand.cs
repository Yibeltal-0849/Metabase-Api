


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cEmplyeBenefits.cEmplyeBenefitsInsert.cEmplyeBenefitsInsertCommand
{

    /// @author  Shimels Alem  c_Emplye_BenefitsInsert stored procedure.


    public class cEmplyeBenefitsInsertCommand : IRequest<IList<CEmplyeBenefits_Name>>
    {
        public string Name { get; set; }
        public bool? Enable { get; set; }
    }
		
		
		 
	}
 
 