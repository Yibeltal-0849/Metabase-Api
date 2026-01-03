using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.CFile;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.CFile.UpdateCFile
{
    /// @author  Shimels Alem  UpdateCFile stored procedure.
    
    public class UpdateCFileCommand : GetCFileLoadAllVm, IRequest<IList<Proc_C_File_C_File_ID>>
    {
    }
}
