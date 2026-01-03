 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Budget;

namespace Application.Budget.Commands.ArchiveType.ArchiveTypeDelete.ArchiveTypeDeleteCommand
{

    // @author  Shimels Alem  Archive_TypeDelete stored procedure.


    public class ArchiveTypeDeleteCommand : IRequest<IList<Archive_Type_Name_Type>>
    {
        public string Name_Type { get; set; }
    }
		
	}
 
 