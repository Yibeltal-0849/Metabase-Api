


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.GenPostingType.GenPostingTypeInsert.GenPostingTypeInsertCommand
{

    /// @author  Shimels Alem  Gen_Posting_TypeInsert stored procedure.


    public class GenPostingTypeInsertCommand : IRequest<IList<GenPostingType_Code>>
    {
        public string Code { get; set; }
        public bool? Is_Active { get; set; }
    }
		
		
		 
}
 
 