using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.proccItemClass.proccItemClassUpdate.proccItemClassUpdateCommand
{

	/// @author  Shimels Alem  proc_c_ItemClassUpdate stored procedure.


	public class proccItemClassUpdateCommand : IRequest<IList<CItemClass_Name>>
   {
		public string Name { get; set; }
		public bool? Enable { get; set; }
	}
		
		
		 
}

