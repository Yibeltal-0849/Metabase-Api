


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cItemClass.cItemClassInsert.cItemClassInsertCommand
{

	/// @author  Shimels Alem  c_ItemClassInsert stored procedure.


	public class cItemClassInsertCommand : IRequest<IList<CItemClass_Name>>
    {
		public string Name { get; set; }
		public bool? Enable { get; set; }
	}
		
		
		 
	}
 
 