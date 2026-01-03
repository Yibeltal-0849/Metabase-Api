


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CFile.CFileInsert.CFileInsertCommand
{

    /// @author  Shimels Alem  C_FileInsert stored procedure.


    public class CFileInsertCommand : IRequest<IList<CFile_C_File_ID>>
    {
        public System.Guid? C_File_ID { get; set; }
        public string AD_Table_ID { get; set; }
        public string AD_Record_ID { get; set; }
    }
		
		
		 
	}
 
 