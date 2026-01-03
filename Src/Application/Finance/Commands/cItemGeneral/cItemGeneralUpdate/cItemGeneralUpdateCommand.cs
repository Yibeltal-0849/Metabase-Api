using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cItemGeneral.cItemGeneralUpdate.cItemGeneralUpdateCommand
{

	/// @author  Shimels Alem  c_ItemGeneralUpdate stored procedure.


	public class cItemGeneralUpdateCommand : IRequest<IList<CItemGeneral_Item_id>>
   {
        public string UPCSKU { get; set; }
        public string Item_id { get; set; }
        public bool? Partnumber { get; set; }
        public bool? MultiPacks { get; set; }
        public long? ItemClass { get; set; }
        public string Parent_IPCSKU { get; set; }
    }
		
		
		 
	}

