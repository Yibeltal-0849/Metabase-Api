 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cItemGeneral.cItemGeneralDelete.cItemGeneralDeleteCommand
{

    // @author  Shimels Alem  c_ItemGeneralDelete stored procedure.


    public class cItemGeneralDeleteCommand : IRequest<IList<CItemGeneral_Item_id>>
    {
        public string Item_id { get; set; }
    }
		
	}
 
 