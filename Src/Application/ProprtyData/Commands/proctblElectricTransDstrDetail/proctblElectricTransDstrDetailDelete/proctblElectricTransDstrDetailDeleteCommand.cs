 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblElectricTransDstrDetail.proctblElectricTransDstrDetailDelete.proctblElectricTransDstrDetailDeleteCommand
{

    // @author  Shimels Alem  proc_tblElectric_Trans_Dstr_DetailDelete stored procedure.


    public class proctblElectricTransDstrDetailDeleteCommand : IRequest<IList<tblElectricTransDstrDetail_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 