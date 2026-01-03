 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procTINERCA.procTINERCADelete.procTINERCADeleteCommand
{

    // @author  Shimels Alem  proc_TIN_ERCADelete stored procedure.

    public class procTINERCADeleteCommand : IRequest<IList<TINERCA_TIN>>
    {
        public string TIN { get; set; }
    }
		
     
		
		 
}
 
 