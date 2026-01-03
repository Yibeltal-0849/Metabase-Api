


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cPayType.cPayTypeInsert.cPayTypeInsertCommand
{

    /// @author  Shimels Alem  c_PayTypeInsert stored procedure.


    public class cPayTypeInsertCommand : IRequest<IList<CPayType_PayType>>
    {
        public string PayType { get; set; }
        public string GL_Account_Number { get; set; }
        public string OrgCode { get; set; }
    }
		
		
		 
}
 
 