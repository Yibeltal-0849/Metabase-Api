using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.CFile.GetCFileLoadAll;

namespace XOKA.Application.HRA.Quiries.CFile.GetCFileByPrimaryKey
{
    /// @author  Shimels Alem  GetCFileByPrimaryKey stored procedure.
    
    public class GetCFileByPrimaryKey : IRequest<GetCFileLoadAllListVm>
    {
        public Guid C_File_ID { get; set; }
    }
}
