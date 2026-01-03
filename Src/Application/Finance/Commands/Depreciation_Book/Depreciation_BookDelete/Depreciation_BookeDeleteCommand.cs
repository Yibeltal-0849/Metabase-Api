 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.Depreciation_Book.Depreciation_BookDelete.Depreciation_BookDeleteCommand
{

    // @author  Shimels Alem  Document_TypeDelete stored procedure.


    public class Depreciation_BookDeleteCommand : IRequest<IList<Depreciation_Bookid>>
    {
        public int Year { get; set; }
        public string Fixed_Assets_No { get; set; }
        public bool Is_IFRS { get; set; }
    }
		
     
		
		 
}
 
 