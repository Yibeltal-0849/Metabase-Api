using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Finance.Quiries.procCFile.GetprocCFileLoadAll;

namespace Application.Finance.Quiries.procCFile.GetprocCFileByPrimaryKey
{
    /// @author  Shimels Alem proc_C_FileLoadByPrimaryKey stored procedure.

    public class GetprocCFileByPrimaryKey : IRequest<GetprocCFileLoadAllListVm>
    {
        public System.Guid C_File_ID { get; set; }
    }
}
