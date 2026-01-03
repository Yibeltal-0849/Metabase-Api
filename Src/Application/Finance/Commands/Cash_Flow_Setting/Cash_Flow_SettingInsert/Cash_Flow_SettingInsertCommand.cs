


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.Cash_Flow_Setting.Cash_Flow_SettingInsert.Cash_Flow_SettingInsertCommand
{

    /// @author  Shimels Alem  c_Account_CatInsert stored procedure.


    public class Cash_Flow_SettingInsertCommand : IRequest<IList<Cash_Flow_Setting_Code>>
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string GL_Account { get; set; }
        public string Formula { get; set; }
        public bool? Is_Active { get; set; }
    }
		
		
		 
	}
 
 