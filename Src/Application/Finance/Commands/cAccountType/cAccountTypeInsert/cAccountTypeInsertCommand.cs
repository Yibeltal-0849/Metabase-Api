


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cAccountType.cAccountTypeInsert.cAccountTypeInsertCommand
{

    /// @author  Shimels Alem  c_Account_TypeInsert stored procedure.


    public class cAccountTypeInsertCommand : IRequest<IList<CAccountType_Id>>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int? Catagory { get; set; }
    }
		
		
		 
	}
 
 