


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cItemGeneral.cItemGeneralInsert.cItemGeneralInsertCommand
{

	/// @author  Shimels Alem  c_ItemGeneralInsert stored procedure.


	public class cItemGeneralInsertCommand : IRequest<IList<CItemGeneral_Item_id>>
    {
        public string UPCSKU { get; set; }
        public string Item_id { get; set; }
        public bool? Partnumber { get; set; }
        public bool? MultiPacks { get; set; }
        public long? ItemClass { get; set; }
        public string Parent_IPCSKU { get; set; }
    }
		
		
		 
	}
 
 