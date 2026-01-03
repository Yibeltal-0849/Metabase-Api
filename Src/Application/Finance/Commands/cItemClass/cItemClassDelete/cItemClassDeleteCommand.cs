 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cItemClass.cItemClassDelete.cItemClassDeleteCommand
{

    // @author  Shimels Alem  c_ItemClassDelete stored procedure.


    public class cItemClassDeleteCommand : IRequest<IList<CItemClass_Name>>
    {

        public string Name { get; set; }
    }
		
     
		
		 
	}
 
 