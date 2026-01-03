 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblCompanys.proctblCompanysDelete.proctblCompanysDeleteCommand
{

    // @author  Shimels Alem  proc_tblCompanysDelete stored procedure.


    public class proctblCompanysDeleteCommand : IRequest<IList<tblCompanys_id>>
    {

        public long id { get; set; }
    }
		
     
		
		 
}
 
 