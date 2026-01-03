using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.Cash_Flow_Setting.Cash_Flow_SettingUpdate.Cash_Flow_SettingUpdateCommand
{

	/// @author  Shimels Alem  c_Account_CatUpdate stored procedure.


	public class Cash_Flow_SettingUpdateCommand : IRequest<IList<Cash_Flow_Setting_Code>>
   {
		public string ID { get; set; }
		public string Name { get; set; }
		public string GL_Account { get; set; }
		public string Formula { get; set; }
		public bool? Is_Active { get; set; }
	}
		
		
		 
	}

