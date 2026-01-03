 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.Cash_Flow_Setting.Cash_Flow_SettingDelete.Cash_Flow_SettingDeleteCommand
{

    // @author  Shimels Alem  c_Account_CatDelete stored procedure.


    public class Cash_Flow_SettingDeleteCommand : IRequest<IList<Cash_Flow_Setting_Code>>
    {
        public string ID { get; set; }
    }
		
     
		
		 
	}
 
 