using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cItemClass.cItemClassUpdate.cItemClassUpdateCommand
{

	/// @author  Shimels Alem  c_ItemClassUpdate stored procedure.


	public class cItemClassUpdateCommand : IRequest<IList<CItemClass_Name>>
   {
		public string Name { get; set; }
		public bool? Enable { get; set; }
	}
		
		
		 
	}

