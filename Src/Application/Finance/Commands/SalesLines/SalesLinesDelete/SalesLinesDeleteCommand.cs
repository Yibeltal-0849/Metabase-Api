 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SalesLines.SalesLinesDelete.SalesLinesDeleteCommand
{

    // @author  Shimels Alem  Sales_LinesDelete stored procedure.


    public class SalesLinesDeleteCommand : IRequest<IList<Sales_Lines_Sales_Line_ID>>
    {
        public string Sales_Line_ID { get; set; }
    }
		
     
		
		 
}
 
 