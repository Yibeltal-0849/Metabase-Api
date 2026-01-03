 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CFile.CFileDelete.CFileDeleteCommand
{

    // @author  Shimels Alem  C_FileDelete stored procedure.


    public class CFileDeleteCommand : IRequest<IList<CFile_C_File_ID>>
    {
        public System.Guid C_File_ID { get; set; }
    }
		
     
		
		 
	}
 
 