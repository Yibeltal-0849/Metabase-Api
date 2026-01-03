


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procPJobLineType.procPJobLineTypeInsert.procPJobLineTypeInsertCommand
{

    /// @author  Shimels Alem  proc_P_Job_Line_TypeInsert stored procedure.


    public class procPJobLineTypeInsertCommand : IRequest<IList<PJobLineType_Code>>
    {
        public string Code { get; set; }
        public bool? IsActive { get; set; }
    }
		
		
		 
}
 
 