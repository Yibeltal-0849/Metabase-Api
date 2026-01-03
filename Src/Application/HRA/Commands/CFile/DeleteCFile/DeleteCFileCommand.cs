using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.CFile.DeleteCFile
{
    /// @author  Shimels Alem  DeleteCFile stored procedure.
    
    public class DeleteCFileCommand : IRequest<IList<Proc_C_File_C_File_ID>>
    {
        public Guid C_File_ID { get; set; }
    }
}
